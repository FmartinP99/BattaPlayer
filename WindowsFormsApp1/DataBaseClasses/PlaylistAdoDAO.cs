using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using PlaylistM.Model;
using MediaM.Model;

namespace PlaylistM.DAO
{
    internal class PlaylistAdoDAO
    {
        private static readonly string conn_string = $@"Data Source={Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Data", "data.db")};";
        public bool AddPlaylistModel(String playlist)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            using SQLiteConnection conn = new SQLiteConnection(conn_string);

            conn.Open(); //kapcsolat nyitása


            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Playlist " +
                "(Playlist) VALUES " +
                "(@Playlist)";


            command.Parameters.Add("Playlist", System.Data.DbType.String).Value = playlist;


            try
            {
                int code = command.ExecuteNonQuery();
                if (code != 1) return false;
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }

        }

        public bool DeletePlaylist(String playlist)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Playlist WHERE Playlist = @Playlist";
            command.Parameters.Add("@Playlist", DbType.String).Value = playlist;

            try
            {
                int code = command.ExecuteNonQuery();
                if (code != 1) return false;
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }

        }



        public bool DeleteAllPlaylist()
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Playlist";
            try
            {
                int code = command.ExecuteNonQuery();
                if (code != 1) return false;
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }

        }


        public PlaylistModel GetPlaylistByID(int playlist_id)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Playlist WHERE playlist_id = @playlist_id";
            command.Parameters.Add("@playlist_id", DbType.Int16).Value = playlist_id;


            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new PlaylistModel
                {
                    playlist_id = reader.GetInt16(reader.GetOrdinal("playlist_id")),
                    Playlist = reader.GetString(reader.GetOrdinal("Playlist"))
                };
            }
            return new PlaylistModel(-1, "");
        }


        public PlaylistModel GetPlaylistByName(string playlist)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Playlist WHERE Playlist = @playlist";
            command.Parameters.Add("@playlist", DbType.String).Value = playlist;


            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new PlaylistModel
                {
                    playlist_id = reader.GetInt16(reader.GetOrdinal("playlist_id")),
                    Playlist = reader.GetString(reader.GetOrdinal("Playlist"))
                };
            }
            return new PlaylistModel(-1, "");
        }

        public void ModifyPlaylistName(string old_name, string new_name)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Playlist SET Playlist = @new_name WHERE Playlist = @old_name";
            command.Parameters.Add("@new_name", DbType.String).Value = new_name;
            command.Parameters.Add("@old_name", DbType.String).Value = old_name;
            command.ExecuteNonQuery();

        }


        public IEnumerable<PlaylistModel> GetPlaylists()
        {
            List<PlaylistModel> playlists = new List<PlaylistModel>();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Playlist";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                playlists.Add(
                    new PlaylistModel
                    {
                        playlist_id = reader.GetInt16(reader.GetOrdinal("playlist_id")),
                        Playlist = reader.GetString(reader.GetOrdinal("Playlist")),
                    }
                );
            }
            return playlists;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MediaPlaylistM.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WMediaPlaylistM.DTO;

namespace MediaPlaylistM.DAO
{
    internal class MediaPlaylistAdoDAO
    {
        private static readonly string conn_string = $@"Data Source={Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Data", "data.db")};";
        public bool AddMediaPlaylistModel(int media_id, int playlist_id)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            using SQLiteConnection conn = new SQLiteConnection(conn_string);

            conn.Open(); //kapcsolat nyitása


            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO MediaPlaylist " +
                "(media_id, playlist_id) VALUES " +
                "(@media_id, @playlist_id)";


            command.Parameters.Add("media_id", System.Data.DbType.Int16).Value = media_id;
            command.Parameters.Add("playlist_id", System.Data.DbType.Int16).Value = playlist_id;


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


        public void AddMultipleMediaPlaylistModel(List<int> media_ids, int playlist_id)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open(); 
            using (var transaction = conn.BeginTransaction())
            {
                try
                {

                    foreach (var mid in media_ids)
                    {
                        SQLiteCommand command = conn.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO MediaPlaylist " +
                            "(media_id, playlist_id) VALUES " +
                            "(@media_id, @playlist_id)";
                        command.Parameters.Add("media_id", System.Data.DbType.Int16).Value = mid;
                        command.Parameters.Add("playlist_id", System.Data.DbType.Int16).Value = playlist_id;
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //rollbacking if fails
                    transaction.Rollback();

                }

            }
        }





        public bool ClearMediaPlaylist(int playlist_id)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM MediaPlaylist WHERE playlist_id = @playlist_id";
            command.Parameters.Add("@playlist_id", DbType.Int16).Value = playlist_id;
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



        public bool DeleteAllMediaPlaylistModel()
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM MediaPlaylist";
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

        public IEnumerable<MediaPlaylistDTO> GetMediaPlaylistModels()
        {
            List<MediaPlaylistDTO> mediaplaylists = new List<MediaPlaylistDTO>();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Media.Mediapath, Playlist.Playlist " +
                "FROM MediaPlaylist JOIN Media ON " +
                "MediaPlaylist.media_id = Media.media_id " +
                "JOIN Playlist ON " +
                "MediaPlaylist.playlist_id = Playlist.playlist_id";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mediaplaylists.Add(
                    new MediaPlaylistDTO
                    {
                        Mediapath = reader.GetString(reader.GetOrdinal("Mediapath")),
                        Playlist = reader.GetString(reader.GetOrdinal("Playlist")),
                    }
                );
            }
            return mediaplaylists;
        }



        public IEnumerable<MediaPlaylistDTO> GetMediaPlaylistModels(int playlist_id)
        {
            List<MediaPlaylistDTO> mediaplaylists = new List<MediaPlaylistDTO>();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Media.Mediapath, Playlist.Playlist " +
                "FROM MediaPlaylist JOIN Media ON " +
                "MediaPlaylist.media_id = Media.media_id " +
                "JOIN Playlist ON " +
                "MediaPlaylist.playlist_id = Playlist.playlist_id " +
                "WHERE MediaPlaylist.playlist_id = @playlist_id";

            command.Parameters.Add("@playlist_id", DbType.Int16).Value = playlist_id;

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mediaplaylists.Add(
                    new MediaPlaylistDTO
                    {
                        Mediapath = reader.GetString(reader.GetOrdinal("Mediapath")),
                        Playlist = reader.GetString(reader.GetOrdinal("Playlist")),
                    }
                );
            }
            return mediaplaylists;
        }


        public List<int> GetMediaPathsForPlaylistTExclusive(int playlist_id)
        {
            List<int> mediapaths = new List<int>();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Media.media_id FROM MediaPlaylist JOIN Media ON MediaPlaylist.media_id = Media.media_id " +
                "WHERE MediaPlaylist.playlist_id = @playlist_id AND NOT EXISTS " +
                "(SELECT 1 FROM MediaPlaylist AS MP WHERE MP.media_id = MediaPlaylist.media_id AND MP.playlist_id != @playlist_id)";

            command.Parameters.Add("@playlist_id", DbType.Int16).Value = playlist_id;

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mediapaths.Add(reader.GetInt16(reader.GetOrdinal("media_id")));
            }
            return mediapaths;
        }



    }
}

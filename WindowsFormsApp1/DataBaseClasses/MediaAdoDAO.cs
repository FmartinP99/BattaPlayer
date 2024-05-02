using MediaM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection;

namespace MediaM.DAO
{
    internal class MediaAdoDAO
    {
        private static readonly string conn_string = $@"Data Source={Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Data", "data.db")};";
        public bool AddMediaModel(String mediapath)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            using SQLiteConnection conn = new SQLiteConnection(conn_string);

            conn.Open(); //kapcsolat nyitása


            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Media " +
                "(Mediapath) VALUES " +
                "(@Mediapath)";


            command.Parameters.Add("Mediapath", System.Data.DbType.String).Value = mediapath;


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



        public void AddMultipleMediaModel(List<string> mediapaths)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            using SQLiteConnection conn = new SQLiteConnection(conn_string);

            conn.Open(); 


            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    foreach (var mp in mediapaths)
                    {
                        SQLiteCommand command = conn.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Media " +
                                            "(Mediapath) VALUES " +
                                            "(@Mediapath)";

                  
                        command.Parameters.Add("Mediapath", System.Data.DbType.String).Value = mp;
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // rollbacking if fails 
                    transaction.Rollback();               
                }

            }
        }





        public bool DeleteMedia(int media_id)
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Media WHERE media_id = @media_id";
            command.Parameters.Add("@MediaPath", DbType.Int16).Value = media_id;

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



        public bool DeleteAllMedia()
        {
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Media";
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

        public MediaModel GetMediaByID(int media_id)
        {
            
           
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Media WHERE media_id = @media_id";
            command.Parameters.Add("@media_id", DbType.Int16).Value = media_id;


            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new MediaModel
                {
                    media_id = reader.GetInt16(reader.GetOrdinal("media_id")),
                    Mediapath = reader.GetString(reader.GetOrdinal("Mediapath"))
                };
            }
            
            return new MediaModel(-1, "");
        }


        public IEnumerable<MediaModel> GetMedias()
        {
            List<MediaModel> medias = new List<MediaModel>();
            using SQLiteConnection conn = new SQLiteConnection(conn_string);
            conn.Open();
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Media";

            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                medias.Add(
                    new MediaModel
                    {
                        media_id = reader.GetInt16(reader.GetOrdinal("media_id")),
                        Mediapath = reader.GetString(reader.GetOrdinal("Mediapath")),
                    }
                );
            }
            return medias;
        }
    }
}

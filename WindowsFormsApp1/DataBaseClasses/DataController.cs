using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaM.DAO;
using PlaylistM.Model;
using PlaylistM.DAO;
using MediaPlaylistM.DAO;
using MediaPlaylistM.Model;
using MediaM.Model;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using WMediaPlaylistM.DTO;

namespace WindowsFormsApp1.DAO
{

    internal class DataController
    {
        private readonly static MediaAdoDAO mediaDao = new MediaAdoDAO();
        private readonly static PlaylistAdoDAO playlistDao = new PlaylistAdoDAO();
        private readonly static MediaPlaylistAdoDAO mediaplaylistDao = new MediaPlaylistAdoDAO();  

        public DataController()
        {
        }

        public void deleteEntireData()
        {
                mediaplaylistDao.DeleteAllMediaPlaylistModel();
                mediaDao.DeleteAllMedia();
                playlistDao.DeleteAllPlaylist();
        }
        public List<string[]> getMedias(string playlist = "temp")
        {
            /// if playlist == "temp" it returns all the medias from the database,
            /// otherwise it returns only those where media.playlist == playlist.

            IEnumerable<MediaPlaylistDTO> mpcoll;
            if (playlist == "temp") mpcoll = mediaplaylistDao.GetMediaPlaylistModels();
            else
            {
                PlaylistModel playlistmodel = playlistDao.GetPlaylistByName(playlist);
                mpcoll = mediaplaylistDao.GetMediaPlaylistModels(playlistmodel.playlist_id);
            }

            List<string[]> medias = new List<string[]>();

            foreach (MediaPlaylistDTO mp in mpcoll)
            {
                medias.Add(new string[] { mp.Mediapath, mp.Playlist });
            }
            return medias;
        }

        public bool clearPlaylist(String playlist)
        {
            int playlist_id = playlistDao.GetPlaylistByName(playlist).playlist_id;
            return mediaplaylistDao.ClearMediaPlaylist(playlist_id);
        }

        public void deletePlaylist(String playlist)
        {
            int playlist_id = playlistDao.GetPlaylistByName(playlist).playlist_id;
            //getting those medias that are only exists in the playlist that is to be deleted
            List<int> medias_to_delete = mediaplaylistDao.GetMediaPathsForPlaylistTExclusive(playlist_id);
            //clearing the connection table
            this.clearPlaylist(playlist);
            //deleting the playlist
            playlistDao.DeletePlaylist(playlist);
            //deleting the medias that are only exists in the playlist that is to be deleted
            foreach(int medias_id in medias_to_delete) mediaDao.DeleteMedia(medias_id);


        }

        public void modifyPlaylistName(string old_name, string new_name)
        {
           playlistDao.ModifyPlaylistName(old_name, new_name);  
        }


        public List<string> getMediaModells()
        {
            IEnumerable<MediaModel> medcoll = mediaDao.GetMedias();

            List<string> medias = new List<string>();

            foreach (MediaModel med in medcoll)
            {
                medias.Add(med.Mediapath);
            }
            return medias;
        }


        public List<string> getPlaylistModells()
        {
            IEnumerable<PlaylistModel> plcoll = playlistDao.GetPlaylists();

            List<string> playlists = new List<string>();

            foreach (PlaylistModel pl in plcoll)
            {
                playlists.Add(pl.Playlist);
            }
            return playlists;
        }


        public bool addBulk(List<string> mediasToAdd, string playlist)
        {
            /// Adds multiple medias into 1 playlist. Optimized for adding a lot of songs at once.

            //to ensure that all of the records are existing
            mediaDao.AddMultipleMediaModel(mediasToAdd);
            playlistDao.AddPlaylistModel(playlist);

            IEnumerable<MediaModel> medias = mediaDao.GetMedias();
            IEnumerable<PlaylistModel> playlists = playlistDao.GetPlaylists();


            //getting all the medias from the Database and selecting only
            //those media id's that are in the List<string> mediasToAdd variable.
            //it is necessary because the media_id property was made upon inserting, it didn't exist before.
            List<int> media_ids = (from mediaToAdd in mediasToAdd
                                   join mediaModel in medias on 
                                   mediaToAdd equals mediaModel.Mediapath
                                   select mediaModel.media_id).ToList();

            //can only insert into 1 playlist at a time by design
            int pid = playlistDao.GetPlaylistByName(playlist).playlist_id;


            mediaplaylistDao.AddMultipleMediaPlaylistModel(media_ids, pid);

            return true;

        }


        public bool AddPlaylistModel(string playlist)
        {
            return playlistDao.AddPlaylistModel(playlist);
        }


        public List<string> GetPlaylists() {
        
            List<string> playlists = playlistDao.GetPlaylists().Select(x => x.Playlist).ToList();
            return playlists;
        }



    }
}

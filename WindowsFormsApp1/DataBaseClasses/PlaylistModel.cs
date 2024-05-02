using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistM.Model
{
    internal class PlaylistModel
    {
        internal int playlist_id { get; set; }
        internal string Playlist { get; set; }
        public PlaylistModel(int playlist_id, string playlist)
        {
            this.playlist_id = playlist_id; 
            this.Playlist = playlist;
        }
        public PlaylistModel()
        {
        
        }

    }
}

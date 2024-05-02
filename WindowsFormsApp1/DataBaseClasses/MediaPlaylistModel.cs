using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlaylistM.Model
{
    internal class MediaPlaylistModel
    {
        internal int mediaplaylist_id { get; set; }
        internal int media_id { get; set; }
        internal int playlist_id { get; set; }


        public MediaPlaylistModel(int media_id, int playlist_id)
        {
            this.media_id = media_id;
            this.playlist_id = playlist_id;
        }

        public MediaPlaylistModel()
        {
        }
    }
}

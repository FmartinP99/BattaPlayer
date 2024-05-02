using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaM.Model
{
    internal class MediaModel
    {
        internal int media_id { get; set; }
        internal string Mediapath { get; set; }
        internal MediaModel(int media_id, string Mediapath)
        {
            this.media_id = media_id;
            this.Mediapath = Mediapath;

        }
        internal MediaModel()
        {

        }
    }
}

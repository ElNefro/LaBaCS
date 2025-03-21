using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecttt
{
    public class MusicAlbum : Media
    {
        public string Artist { get; set; }
        public int TrackCount { get; set; }

        public MusicAlbum(string title, string author, int yearPublished, bool isAvailable, string artist, int trackCount) : base(title, author, yearPublished, isAvailable)
        {
            Artist = artist;
            TrackCount = trackCount;
        }
    }
}

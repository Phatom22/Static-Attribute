using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    class Songs
    {
        public string title;
            public string artist;
        public int duration;

        public static int songCount;
            public Songs(string aTitle, string aArtist, int aDuration) {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;

        }
    }
}

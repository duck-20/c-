using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclassatt
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount=0;
        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }
        //creating method to display the song count cause static is only valid within class. or program
        public int GetSongCount()
        {
            return songCount;
        }
    }
}

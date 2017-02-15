using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
     class Songs : Song
     {
        private List<Song> songs;

        public Song FindSong(string Name)
        {
            foreach (Song song in songs)
            {
                if (Name.Equals(song.Name))
                {
                    return song;
                }
            }
            return null;
            
        }
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CD data:");
            List<Cd> cds = new List<Cd>();
            
            
            cds.Add( new Cd { Artist = "U2", Album = "Joshua Tree", Price = 17 });
            Console.WriteLine(cds.ElementAt(0).ToString());

            //songs
            List<Song> songs = new List<Song>();
            Console.WriteLine("Songs:");
            songs.Add(new Song { Name = "Where the Streets Have No Name", Duration = "5:37" });
            songs.Add(new Song { Name = "I Still Haven’t Found What I’m Looking For", Duration = "4:37" });
            songs.Add(new Song { Name = "With Or Without You ", Duration = "4:56" });
            songs.Add(new Song { Name = "Bullet The Blue Sky", Duration = "4:32" });
            songs.Add(new Song { Name = "Running To Stand Still", Duration = "4:18" });
            songs.Add(new Song { Name = "Red Hill Mining Town", Duration = "4:52" });
            songs.Add(new Song { Name = "In God's Country", Duration = "2:57" });
            songs.Add(new Song { Name = "Trip Through Your Wires", Duration = "3:32" });
            songs.Add(new Song { Name = "One Tree Hill", Duration = "3:32" });
            songs.Add(new Song { Name = "Exit", Duration = "4:13" });
            songs.Add(new Song { Name = "Mothers of the Disappeared", Duration = "5:14" });

            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

            /*string songname = "One Love";
            Console.WriteLine("Find song: " + songname);
            Songs Name = songs.FindSong(songname);
            if (songs != null)
            {
                Console.WriteLine(songs.ToString());
            }
            else
            {
                Console.WriteLine("Can't find a song with that name.");
            }*/

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
     class Cd
     {

         public string Artist { get; set; }
         public string Album { get; set; }
         public double Price { get; set; }

         public override string ToString()
         {
             return "Artist - " + Artist + "\n" + "Album - " + Album + ",  " + Price + "e" + "\n";
         }

     }
}

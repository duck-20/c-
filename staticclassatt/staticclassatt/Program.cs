using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclassatt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song hbk=new Song("HBK","Shawn Michael",180);
            Console.WriteLine(Song.songCount);
            Song timeis=new Song("timeup","John Cena",200);

            Console.WriteLine(hbk.artist);
           

            Console.WriteLine(timeis.artist);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(timeis.GetSongCount());

            Console.ReadKey();
        }
    }
}

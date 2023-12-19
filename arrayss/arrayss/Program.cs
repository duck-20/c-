using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple Array using For and foreach
            string[] movies = { "Lord of the Rings","Fight Club","InterStellar","Mars"};
            
            for (int i = 0; i < movies.Length; i++)
            {
                int rank=i+1;
                Console.WriteLine(rank + "." + movies[i]);
            }

            Array.Sort(movies);
            Console.WriteLine("\n");
            Console.WriteLine("List of movies using Foreach:");

            foreach(var a in movies)
            {
                int i = 0;
                i++;
                Console.WriteLine($"{i}.{a}");
            }

            Console.WriteLine("--------------------------------");
            //List
            Console.WriteLine("List:");
            List<string> list = new List<string>();

            list.Add("Dreams");
            list.Add("Miracles");

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nRemoved Dreams:\n");

            list.Remove("Dreams");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }





            
            Console.ReadKey();
        }
    }
}

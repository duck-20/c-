using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1=new Movie("Koii Mil Gaya","Rajnikath","PG");
            Movie movie2 = new Movie("Avengers", "Iron Man", "PG-13");
            movie2.Rating = "Gelo";
            Console.WriteLine(movie1.Rating);//print PG cause PG is valid
            Console.WriteLine(movie2.Rating);//Prints NR cause condtion not valid'

            Console.ReadKey();
        }
    }
}

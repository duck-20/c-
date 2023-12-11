using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1getset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1=new Book ("Lord OF the Rings","Audhc",500,"Action");
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.Series);
            Console.WriteLine("__________");
            book1.Series = "nasd";
            Console.WriteLine(book1.Series);
            Console.WriteLine("__________");
            book1.Series = "18+";
            Console.WriteLine(book1.Series);

            Console.ReadKey();
        }
    }
}

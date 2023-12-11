using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsandobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Colleans","Jack",200);

            Book book1=new Book("LOTR","Rick",900);

            Console.WriteLine(book1.name);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsandobj
{
    internal class Book
    {
        public string name;
        public string writer;
        public int page;
        public Book(string title,string author,int pages)
        {
            Console.WriteLine("Creating Book!");
            name=title;
            writer=author;
            page = pages;
            Console.WriteLine($"Book Name:{name}");
            Console.WriteLine($"Book Author:{writer}");
            Console.WriteLine($"No. Of Pages:{page}");
            Console.WriteLine("_________________");
        }
    }
}

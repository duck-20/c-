using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmethodandclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(4));
            UsefulTools.SayHi("Ayush");

            Console.ReadKey();
        }
    }
}

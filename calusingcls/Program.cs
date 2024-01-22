using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calusingcls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add add=new Add(4,4);
            Add add1 = new Add(5,5);
            Add add2= new Add();
            Console.ReadKey();
        }
    }
}

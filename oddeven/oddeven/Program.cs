using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number:");
            a=int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine($"{a} is an even number.");
            else Console.WriteLine($"{a} is odd number.");
            Console.ReadKey();
        }
    }
}

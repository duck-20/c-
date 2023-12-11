using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter another number:");
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The Sum of {num1} and {num2} is: {num1 + num2}");
            Console.ReadKey();
        }
    }
}

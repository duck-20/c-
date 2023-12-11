using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter first number:");
            a = double.Parse(Console.ReadLine());
            Console.Write("");
            string op=Console.ReadLine();
            Console.WriteLine("Enter second number:");
            b= double.Parse(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine("add:" + (a + b));
            }
            else if(op == "-") {
                Console.WriteLine("Sub:" + (a - b));


            }
            else if(op == "*")
            {
                Console.WriteLine("mul:" + (a * b));
            }
            else if( op == "/") {
                Console.WriteLine("div:" + (b / a));
            }
            else { Console.WriteLine("Invalid"); }
            Console.ReadKey();
        }
    }
}

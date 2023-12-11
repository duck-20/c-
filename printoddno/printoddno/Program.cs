using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printoddno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the initial number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Final number:");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine($"The odd no. between {a} and {b} are:");
            for (int i = a;i<=b;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}

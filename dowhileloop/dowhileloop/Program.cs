using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            int value;
            int result =number*number;
            int limit = 0;
            int maxlimit = 5;
            do
            {
                Console.Write("Write the square of {0}:",number);
                value = int.Parse(Console.ReadLine());
                if(value != result)
                {
                    Console.WriteLine("Try Again!");
                    limit++;
                    Console.WriteLine("---------------------------------");
                }
                else
                {
                    Console.WriteLine("Right answer!");
                    break;
                }

            }while( limit <maxlimit );
            if( limit ==maxlimit ) {
                Console.Clear();
            Console.WriteLine("Max Limit Reached!");
            }
            Console.ReadKey();
        }
    }
}

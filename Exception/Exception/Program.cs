using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number:");
                int num2 = int.Parse(Console.ReadLine());


                Console.WriteLine(num1 / num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
/*            finally
            {
                Console.WriteLine("unsuc");
            }
*/
            Console.ReadKey();
        }
    }
}

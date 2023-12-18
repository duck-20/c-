using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace outandrefer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Out and Ref Helps to pass variable to the methods or parameters.
            //Ref KeyWord may modify the data.
            int num1 = 5;
            int num2 = 2;


            //Value before swapping using ref
            Console.WriteLine($"Values Before Swapping: {num1} {num2}");

            //Without using ref
            Swap2(num1, num2);
            Console.WriteLine($"Values Without Ref: {num1} {num2}");


            //Swapping using ref
            Swap(ref num1,ref num2);
            Console.WriteLine($"Values  After Swapping: {num1} {num2}");


            Console.WriteLine("----------------------------------------");
            //In Keyword doesnt allow modification of data.It has a private modifier integrated
            //can't override;
            float balance =  500;
            DisplayBalance(in balance);
            
            Console.WriteLine("----------------------------------------");


            //Out Keyword must modifie the value and must be initalized within the method
            Console.WriteLine("Out");
            Console.WriteLine("Check's Whether it's a number or not:");
            string anything=Console.ReadLine();
            int num;
            if(int.TryParse(anything, out num))
            {
                //Success
                Console.WriteLine($"{num} is a number");
                
            }
            else
            {
                //fail
                Console.WriteLine($"{num} is not a number");
            }


            int number1 = 5;
            int number2 = 2;

            if(TryDivide(number1 ,number2,out int result)) {
            Console.WriteLine(number1/number2);
            }
            else
            {
                Console.WriteLine("Not Divisible by 0.");
            }





            Console.ReadKey();
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Swap2(int x,int y)
        {
            int temp = x;   
            x = y;
            y = temp;
        }

        static void DisplayBalance(in float currentBalance)
        {
            Console.WriteLine("Your Balance is : $" + currentBalance);
        }

        static bool TryDivide(int x,int y,out int result)
        {
            if (y != 0) {
                result = x / y;
                return true;
            }
            else
            {
                result = default;
                return false;
            }

        }
    }
}

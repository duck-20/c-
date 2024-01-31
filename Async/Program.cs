using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string food = "MoMo";
            Waiter();
            Customer(food);
            Cook(food);
            Console.ReadKey();
        }
        static async Task Waiter()
        {
           Console.WriteLine($"Waiter: What's your order?");
           await Task.Delay(2000);
           Console.WriteLine($"Waiter: Order Taken!");
        }
        static void Customer(string foodName)
        {
            Console.WriteLine($"Customer: I would like to have a {foodName}.");
        }
        static async Task Cook(string foodName)
        {
            await Task.Delay(4000);
            Console.WriteLine($"Cook: {foodName} is being prepared.");
            await Task.Delay(2000);
            Console.WriteLine($"Cook: {foodName} is ready.");
        }
    }
}

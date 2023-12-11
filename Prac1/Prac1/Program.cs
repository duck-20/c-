using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Write your name");
            name=Console.ReadLine();
            string subject;
            Console.WriteLine("Enter your subject name:");
            subject=Console.ReadLine();
            int sid;
            Console.WriteLine("Enter your sid:");
            sid=int.Parse(Console.ReadLine());
            int age;
            Console.WriteLine("Enter your age:");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Subject:{subject}");
            Console.WriteLine($"SID.:{sid}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine("__________");
            Console.ReadLine();
        }
    }
}

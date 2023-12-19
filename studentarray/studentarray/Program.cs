using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("How Many Students are there?");
            length = int.Parse(Console.ReadLine());
            Console.Clear();


            string[] studentNames = new string[length];
            Console.WriteLine("Enter The Name Of the Students:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = Console.ReadLine();
            }
            Array.Sort(studentNames);
            Console.WriteLine("------------------------");
            int rollNo = 0;
            foreach (string studentName in studentNames)
            {
                rollNo++;
                Console.WriteLine(rollNo+"."+studentName);
            }


            Console.ReadLine();
        }
    }
}

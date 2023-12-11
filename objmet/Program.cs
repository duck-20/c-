using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objmet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1=new Student("Ayush","BCA",3.1);
            Student student2 = new Student("Robina", "BCA", 3.8);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadKey();
        }
    }
}

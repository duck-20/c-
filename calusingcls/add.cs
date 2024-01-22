using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calusingcls
{
    internal class Add
    {
        public int num1;
        public int num2;
        public Add(int a=5,int b = 4)
        {
            this.num1 = a; this.num2 = b;
            Console.WriteLine($"Sum:{num1 + num2}");
        }
    }
}

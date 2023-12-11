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
        public Add(int a,int b)
        {
            num1 = a; num2 = b;
            Console.WriteLine(num1 + num2);
        }
    }
}

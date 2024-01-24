using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stringsum
{
    public class Program
    {
        static void Main(string[] args)
        {
          Sum sum = new Sum();
          Console.WriteLine(sum.Add("1","2"));
          Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef= new Chef();
            chef.MakeChicken();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inher
{
    internal class ItalianChef:Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef can make Pasta.");
        }
            public override void MakeSpecialDish()
            {
                Console.WriteLine("The Chef makes Pizza.");
            }
        }
    }


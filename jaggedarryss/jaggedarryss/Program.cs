using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarryss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged arrays
            int[][] marks = new int[3][];
            marks[0] = new int[] {1,2,3} ;
            marks[1] = new int[] { 4, 5 };
            marks[2] = new int[] {6, 7,8,9};

            for(int i = 0; i < marks.Length; i++)
            {
                for(int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine(marks[i][j]);
                }

            }
            Console.ReadKey();
        }
    }
}

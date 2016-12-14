using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray2 = new int[][] 
                {
                    new int[] {1,3,5,7,9},
                    new int[] {0,2,4,6},
                    new int[] {11,22}
                };

            
            Console.WriteLine(jaggedArray2.GetLength(0));

            Console.WriteLine(jaggedArray2.Length);

            Console.WriteLine(jaggedArray2[2][3]);

        }
    }
}

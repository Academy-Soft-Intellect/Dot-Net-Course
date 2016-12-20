using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNumberOfParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //Console.WriteLine("Call method with 2 params");
            //PrintNames(count, "a", "B");

            //Console.WriteLine("Call method with 3 params");
            //PrintNames(count, "c", "d", "e");


            //Console.WriteLine("Call method with 4 params");
            //PrintNames(count, "f", "g", "h", "i");

            int[] numbers2 = new int[] { 2, 21, 42, 14, 332, 125, 562, 16, 12, 13 };

            PrintArrayReverse(numbers2);
        }

        private static void PrintNames(int counter, params string[] letters)
        {
            Console.WriteLine(counter);
            foreach (string name in letters)
            {
                Console.Write(name + "\t");
            }
            Console.WriteLine();
        }

        private static void PrintArrayReverse(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

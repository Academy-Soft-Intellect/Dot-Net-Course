using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.WriteLine("First Numbers");
            PrintNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Second numbers");
            int[] numbers2 = new int[] { 2, 21, 42, 14, 332, 125, 562, 16, 12, 13 };
            PrintNumbers(numbers2);


            string[] names = new string[] { "1dsa", "2das", "3sadas" };

            //PrintNumbers(names);

            PrintNumbers(numbers, numbers2);
        }

        private static void PrintNumbers(int[] numbers, int[] numbers2)
        {
            throw new NotImplementedException();
        }

        private static void PrintNumbers(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintNumbers(int[] array2)
        {
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }


        
    }
}

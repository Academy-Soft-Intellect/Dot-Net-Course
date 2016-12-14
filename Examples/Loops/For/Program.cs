using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //int b = 0;
            //for (int index = 0; index < 10; index++)
            //{
            //    Console.WriteLine(index);
            //}

            //Console.WriteLine("Enter a number:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //int k = int.Parse(Console.ReadLine());

            //for (int index = 10; index >= 0; index--)
            //{
            //    Console.WriteLine(index);
            //}

            //for (int i = 0, l = 0; i < 10 && l < 5; i++, l += 2)
            //{
            //    Console.WriteLine("{0} {1}", i, l);
            //}

            int counter = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            //do
            //{
            //    Console.WriteLine("Enter a number to add to the sum");
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;

            //} while (number != 0);
            //Console.WriteLine(sum);

            for (; ; )
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
                if (number==0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}

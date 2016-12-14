using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int myNumber = int.Parse(Console.ReadLine());

            if (myNumber >= 1 && myNumber <= 5)
            {
                if (myNumber % 2 == 0)
                {
                    Console.WriteLine("The number is Even");
                }
                else
                {
                    Console.WriteLine("The number is Odd");
                }
            }
            else if (myNumber >= 6 && myNumber <= 15)
            {
                if (myNumber % 3 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                if (myNumber > 0)
                {
                    Console.WriteLine("Positive");
                }
                else if (myNumber == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 5;
            //int secondNumber = 6;
            //int thirdNumber = firstNumber + secondNumber;
            //Console.WriteLine(thirdNumber);

            //firstNumber = firstNumber + 3;
            //firstNumber += 3;
            //Console.WriteLine(firstNumber);

            //secondNumber++;
            //Console.WriteLine(secondNumber);

            //Console.WriteLine(thirdNumber--);
            //Console.WriteLine(thirdNumber);

            int a = 22;

            int b = 7;

            Console.WriteLine(a % b);

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Pow(2, 10));

            Console.WriteLine(Math.Sqrt(390625));

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            string first = "First ";
            string second = "Second";
            Console.WriteLine(first + second);


            Console.WriteLine(second[0]);

            byte testByte = 254;
            testByte += 6;
            Console.WriteLine(testByte);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Call the method");
            //Hello();
            //Console.WriteLine("Method was called");
            //Console.WriteLine("Enter text to be printed");
            //string text = Console.ReadLine();
            //Print(text);

            Console.WriteLine("Enter first number:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = int.Parse(Console.ReadLine());

            bool result = CompareNumbers(firstNumber, secondNumber);

            Console.WriteLine(result);
            Console.WriteLine(CompareNumbers(firstNumber, secondNumber));
        }

        private static bool CompareNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber == secondNumber;
        }

        private static void Print(string label)
        {
            Console.WriteLine(label);
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        private static void PrintMyInfo(int age, string name)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        private static void PrintMyName(string firstName)
        {
            Console.WriteLine(firstName);
        }

        private static void PrintMyName()
        {
            Console.WriteLine("Hello");
        }



    }
}

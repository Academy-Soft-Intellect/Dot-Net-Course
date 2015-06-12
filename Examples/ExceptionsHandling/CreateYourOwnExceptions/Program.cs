using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourOwnExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Enter a value to calculate the sqrt of: ");
                    double inputValue = Convert.ToDouble(Console.ReadLine());
                    double result = SquareRoot(inputValue);

                    Console.WriteLine("The sqrt of {0} is {1:F6)\n", inputValue, result);
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Enter a double value!\n");
                }
                catch (NegativeNumberException negativeNumberException)
                {
                    Console.WriteLine("\n" + negativeNumberException.Message);
                    Console.WriteLine("Enter a non-negative value!\n");
                }
            } while (continueLoop);
        }

        public static double SquareRoot(double value)
        {
            if (value < 0)
                throw new NegativeNumberException(
                    "Square root of negative number not permitted.");
            else
                return Math.Sqrt(value);
        }
    }
}

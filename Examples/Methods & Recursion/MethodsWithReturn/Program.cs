using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum1 = CalculateSum(numbers);
            Console.WriteLine("Sum of elements in 1st arr is:" + sum1);

            int[] numbers2 = new int[] { 2, 21, 42, 14, 332, 125, 562, 16 };
            int sum2 = CalculateSum(numbers2);
            Console.WriteLine("Sum of elements in 2nd arr is:" + sum2);

            int convertedString = Convert.ToInt32(ReturnAString());
            double a = Math.Pow(sum1,sum2);
            Console.WriteLine(a);
        }

        private static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        private static string ReturnAString()
        {
            return "22";
        }
    }
}

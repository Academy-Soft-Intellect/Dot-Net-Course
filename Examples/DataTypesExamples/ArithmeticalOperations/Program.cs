using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            Console.WriteLine(a + b);

            Console.WriteLine(a++);
            Console.WriteLine(a);

            Console.WriteLine(++b);

            int number1 = 11;
            int number2 = 3;

            double c = (double)number1 / (double)number2;

            Console.WriteLine(c);

            Console.WriteLine(number1 % number2);

            //b = b + a;
            b += a;
            Console.WriteLine(b);
        }
    }
}

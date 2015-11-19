using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingNumberDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //float floatingPoint = 5.5f;
            //Console.WriteLine(floatingPoint);

            //double doubleNUmber = 4.5;
            //Console.WriteLine(doubleNUmber);

            //decimal decimalNumber = 6.7M;
            //Console.WriteLine(decimalNumber);

            float firstFloatNumber = 22f;
            float secondFloatNumber = 7f;

            float floatPI = firstFloatNumber / secondFloatNumber;
            Console.WriteLine(floatPI);

            double firstDoubleNumber = 22;
            double secondDoubleNumber = 7;

            double doublePI = firstDoubleNumber / secondDoubleNumber;
            Console.WriteLine(doublePI);

            decimal firstDecimalNumber = 22;
            decimal secondDecimalNumber = 7;

            decimal decimalPI = firstDecimalNumber / secondDecimalNumber;
            Console.WriteLine(decimalPI);
        }
    }
}

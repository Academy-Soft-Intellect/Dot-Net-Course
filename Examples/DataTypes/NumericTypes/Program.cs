using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //8bit numeric types
            Console.WriteLine("sbyte demo");
            sbyte a = 127;
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine("byte demo");
            byte b = 0;
            Console.WriteLine(b);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            //floating point variables
            float floatNumber = 3.1234563891F;
            Console.WriteLine(floatNumber);
            double doubleNumber = 3.123456789123451789;
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 3.12345678934567891000M;
            Console.WriteLine(decimalNumber);


        }
    }
}

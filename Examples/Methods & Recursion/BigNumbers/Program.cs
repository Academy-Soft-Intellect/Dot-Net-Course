using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = new BigInteger();
            number = 1;

            int number2 = 1;

            for (int i = 1; i < 400; i++)
            {
                number *= i;
            }

            Console.WriteLine(number);
        }
    }
}

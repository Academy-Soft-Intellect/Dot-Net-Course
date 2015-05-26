using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int c = Sum(a, "aaaa", b);

            Console.WriteLine(c);
        }

        private static int Sum(int firstNumber, string name, int b)
        {
            Console.WriteLine(name);
            return firstNumber + b;
        }
    }
}

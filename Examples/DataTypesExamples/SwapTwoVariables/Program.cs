using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A is:");
            Console.WriteLine(a);

            Console.WriteLine("B is:");
            Console.WriteLine(b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("A is:");
            Console.WriteLine(a);

            Console.WriteLine("B is:");
            Console.WriteLine(b);
        }
    }
}

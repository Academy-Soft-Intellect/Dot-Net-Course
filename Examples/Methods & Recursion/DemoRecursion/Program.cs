using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;

            Recursion(start, end);
        }

        private static void Recursion(int start, int end)
        {
            Console.WriteLine(start);
            if (start<end)
            {
                Recursion(start + 1, end);
            }
            Console.WriteLine(start);
        }
    }
}

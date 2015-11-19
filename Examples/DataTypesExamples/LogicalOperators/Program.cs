using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int c = 7;

            Console.WriteLine((a > b) ^ (b < c));

            Console.WriteLine(!(a > b));
        }
    }
}

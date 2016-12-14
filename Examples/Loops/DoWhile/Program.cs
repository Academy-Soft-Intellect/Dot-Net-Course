using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static int b = 6;
        static void Main(string[] args)
        {
            Console.WriteLine(b);
            int a = 0;
            do
            {
                Console.WriteLine(a);
                Test();
                --a;
            } while (a > 0);
        }

        private static void Test()
        {
            Console.WriteLine(b);
        }
    }
}

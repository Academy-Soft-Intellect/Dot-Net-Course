using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            Recursive(n, max, ref sum);
            Console.WriteLine(sum);
        }

        private static void Recursive(int n, int max, ref int sum)
        {
            sum += n;
            if (n < max)
            {
                Recursive(n + 1, max, ref sum);
            }
        }
    }
}

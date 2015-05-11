using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = n;
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i < m; i++)
            {
                n = n * k;
            }

            Console.WriteLine(n);
        }
    }
}

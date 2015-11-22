using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int k = n;
            int m = int.Parse(Console.ReadLine());

            for (int i = 1;; i++)
            {
                Console.WriteLine(i);
                if (i==m)
                {
                    break;
                }
                //n = n * k;
            }

            //Math.Pow(m, n); смята m на степен n

            //Console.WriteLine(n);
        }
    }
}

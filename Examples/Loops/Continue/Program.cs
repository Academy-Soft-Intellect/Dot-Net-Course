using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}

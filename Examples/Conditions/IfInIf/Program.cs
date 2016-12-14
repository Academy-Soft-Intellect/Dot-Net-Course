using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfInIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            if (i > 0)
            {
                if (i < 10)
                {
                    Console.WriteLine(i);
                }

                if (i > 10)
                {
                    Console.WriteLine(i * 10);
                }
            }
            else
            {
                Console.WriteLine("Negative or zero");
            }
        }
    }
}

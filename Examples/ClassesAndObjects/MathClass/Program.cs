using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            Random rand = new Random();
            for (int number = 1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }
}

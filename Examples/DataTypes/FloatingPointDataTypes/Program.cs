using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = (double)22/7;
            Console.WriteLine(x);

            float y = (float)22/7;
            Console.WriteLine(y);

            decimal z = (decimal)22/7;
            Console.WriteLine(z);
        }
    }
}

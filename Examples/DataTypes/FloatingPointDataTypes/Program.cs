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
            //double xx = 22.5;
            //Console.WriteLine(xx);

            //float yy = 12.5f;
            //Console.WriteLine(yy);

            //decimal zz = 26.5m;
            //Console.WriteLine(zz);

            double x = (double)22 / 7;
            Console.WriteLine(x + 30000);

            float y = (float)22 / 7;
            Console.WriteLine(y + 30000);

            decimal z = (decimal)22 / 7;
            Console.WriteLine(z+30000);
        }
    }
}

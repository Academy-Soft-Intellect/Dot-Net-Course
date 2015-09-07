using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceFree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;

            if (a==3 || ++b==8)
            {
                a += b++;
            }

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            string str = "Hello Mark";
            if (str == "Hello")
            {
                i++;
            }
            else if (str=="Hello Joe")
            {
                i += 2;
            }

            Console.WriteLine(i);
        }
    }
}

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
            string str = "Hello";
            if (str == "Hello")
            {
                i++;
            }
            if (str == "Hello Joe")
            {
                i += 2;
            }
            if (str == "Hello Mark")
            {
                i += 3;
            }
            else
            {
                i += 4;
            }
            Console.WriteLine(i);
        }
    }
}

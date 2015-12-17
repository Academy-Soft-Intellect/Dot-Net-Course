using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaa";
            string str2 = "Aaa";


            Console.WriteLine(str1==str2);
            Console.WriteLine(str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}

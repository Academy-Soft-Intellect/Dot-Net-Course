using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            Console.WriteLine(a);

            string b = "Test";
            Console.WriteLine(b);

            object obj = 2.4m;
            Console.WriteLine(obj.GetType());
        }
    }
}

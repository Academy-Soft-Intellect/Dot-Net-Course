using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = MyStaticClass.MyProperty;

            Console.WriteLine(a);

            MyStaticClass.Print();
        }
    }
}

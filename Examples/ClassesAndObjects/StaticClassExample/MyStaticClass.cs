using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    public static class MyStaticClass
    {
        public static int MyProperty = 10;

        public const string ConstString = "Test";

        public static void Print()
        {
            Console.WriteLine("{0} {1}", MyProperty, ConstString);
        }
    }
}

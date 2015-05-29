using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = System.Environment.TickCount;

            //StringBuilder a = new StringBuilder();
            string a = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                a += "MyNameIs";
                //a.Append("MyNameIs");
            }

            Console.WriteLine(System.Environment.TickCount - start);

            Console.WriteLine(a);
        }
    }
}

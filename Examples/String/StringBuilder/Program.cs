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
            int start = Environment.TickCount;

            StringBuilder a = new StringBuilder();
            //string a = string.Empty;

            for (int i = 0; i < 300000; i++)
            {
                //a += "MyNameIs";
                a.Append("MyNameIs");
            }

            Console.WriteLine(Environment.TickCount - start);

            //Console.WriteLine(a);
        }
    }
}

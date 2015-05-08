using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = false;
            bool a2 = true;
            bool a3 = false;
            bool a4 = true;

            bool b1 = false;
            bool b2 = false;
            bool b3 = true;
            bool b4 = true;

            Console.WriteLine(a1 + " || " + b1 + " = " + (a1 || b1));
            Console.WriteLine(a1 + " && " + b1 + " = " + (a1 && b1));
            Console.WriteLine(a1 + " ^ " + b1 + " = " + (a1 ^ b1));
            Console.WriteLine("~" + a1 + " = " + !a1);


            Console.WriteLine(a2 + " || " + b2 + " = " + (a2 || b2));
            Console.WriteLine(a2 + " && " + b2 + " = " + (a2 && b2));
            Console.WriteLine(a2 + " ^ " + b2 + " = " + (a2 ^ b2));
            Console.WriteLine("~" + a2 + " = " + !a2);


            Console.WriteLine(a3 + " || " + b3 + " = " + (a3 || b3));
            Console.WriteLine(a3 + " && " + b3 + " = " + (a3 && b3));
            Console.WriteLine(a3 + " ^ " + b3 + " = " + (a3 ^ b3));
            Console.WriteLine("~" + a3 + " = " + !a3);


            Console.WriteLine(a4 + " || " + b4 + " = " + (a4 || b4));
            Console.WriteLine(a4 + " && " + b4 + " = " + (a4 && b4));
            Console.WriteLine(a4 + " ^ " + b4 + " = " + (a4 ^ b4));
            Console.WriteLine("~" + a4 + " = " + !a4);
        }
    }
}

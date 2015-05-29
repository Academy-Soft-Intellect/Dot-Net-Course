using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name";

            PrintMyName(name);

            Console.WriteLine();
            Console.WriteLine("Waiting....");
            Console.WriteLine();

            string secondName = "Your name";
            PrintMyName(secondName);
        }

        private static void PrintMyName(string name)
        {
            Console.WriteLine(name);
        }



    }
}

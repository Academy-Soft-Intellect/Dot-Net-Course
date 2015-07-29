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
            //string name = "My name";

            //PrintMyName(name);

            PrintMyName();
            Console.WriteLine("Waiting....");
            PrintMyName();
            Console.WriteLine("Done");
            string secondName = "Your name";
            //PrintMyName(secondName);
        }

        private static void PrintMyName()
        {
            Console.WriteLine("Hello");
        }



    }
}

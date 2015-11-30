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

            //PrintMyName();
            //Console.WriteLine("Waiting....");
            //PrintMyName();
            //Console.WriteLine("Done");
            string secondName = "Your name";
            PrintMyName(secondName);

            PrintMyName("dsadasdasda");

            PrintMyInfo(25, "Ivaylo");
        }

        private static void PrintMyInfo(int age, string name)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        private static void PrintMyName(string firstName)
        {
            Console.WriteLine(firstName);
        }

        private static void PrintMyName()
        {
            Console.WriteLine("Hello");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name:");
            //string name = Console.ReadLine();
            //Console.Write("Your name is:");
            //Console.WriteLine(name);

            //Console.WriteLine("Enter a number:");
            //int myNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Your number is:");
            //Console.WriteLine(myNumber);

            //Console.WriteLine("Enter a number:");
            //double myNumber = double.Parse(Console.ReadLine());
            //Console.Write("Your number is:");
            //Console.WriteLine(myNumber);

            //int test;
            //bool success = int.TryParse(Console.ReadLine(), out test);
            //Console.WriteLine(success);

            //Console.WriteLine(test);

            Console.WriteLine("Enter smthng");
            char text = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}

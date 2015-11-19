using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter something:");
            //string myString = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("You entered:");
            //Console.WriteLine(myString);

            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your number is:");
            //Console.WriteLine(number);

            //var key = Console.ReadKey();

            var read = Console.Read();

            Console.WriteLine(read);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            ////readline and readkey
            //Console.WriteLine("Please enter a character:");
            //char str = Console.ReadKey().KeyChar;

            //Console.WriteLine("Your character is: " + str);

            //int/double parse
            Console.WriteLine("Please enter a double");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("Please enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(b);

        }
    }
}

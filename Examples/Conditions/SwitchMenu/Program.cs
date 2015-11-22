using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice: \n I - for integer, D - for real number or S - for string");
            char str = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (str)
            {
                case 'I':
                    Console.WriteLine("Enter number");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(++number);
                    break;

                case 'D':
                    Console.WriteLine("Enter real number");
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(++realNumber);
                    break;

                case 'S': 
                    Console.WriteLine("Enter a text");
                    string myText = Console.ReadLine();
                    Console.WriteLine(myText+"*");
                    break;

                default:
                    Console.WriteLine("Your choice is not correct");
                    break;
            }
        }
    }
}

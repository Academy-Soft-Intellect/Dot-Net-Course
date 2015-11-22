using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region numberSwitch
            Console.WriteLine("Enter digit:");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;

                case 1: Console.WriteLine("One"); break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                case 6:
                    Console.WriteLine("Five or Six");
                    break;

                default:
                    Console.WriteLine("Bigger than 6 or smaller than 0");
                    break;
            }
            #endregion numberSwitch

            #region Test
            //Console.WriteLine("Enter string");
            //string str = Console.ReadLine();

            //switch (str)
            //{
            //    case "a":
            //        Console.WriteLine("A");
            //        break;

            //    case "b":
            //        Console.WriteLine("B");
            //        break;

            //    case "c":
            //        Console.WriteLine("C");
            //        break;

            //    default:
            //        Console.WriteLine("The string is not a, b or c");
            //        break;
            //}
            #endregion

        }
    }
}

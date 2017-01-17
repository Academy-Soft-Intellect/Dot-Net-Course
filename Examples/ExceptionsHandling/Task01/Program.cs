using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number*5);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number");
            }
            finally
            { 
                Console.WriteLine("End of program!");
            }
        }
    }
}

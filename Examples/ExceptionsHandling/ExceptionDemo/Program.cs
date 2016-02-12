using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int a = int.Parse(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("You have to write a number");
            }
            finally
            {
                Console.WriteLine("If you want reset");
            }
        }

    }
}

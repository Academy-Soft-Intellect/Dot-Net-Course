using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.myString);


            Console.WriteLine(Constants.myString + "Is cool");


            string abc = Constants.myString;

            Console.WriteLine(abc);

            Console.ReadLine();
        }
    }
}

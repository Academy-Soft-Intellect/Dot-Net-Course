using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string ourString = "Grseeting you traveler, do you want a cup of fresh you water.";

            Console.WriteLine("String starts with Greeting: {0}", ourString.StartsWith("Greeting"));

            Console.WriteLine("String ends with  '.': {0}", ourString.EndsWith("."));

            Console.WriteLine("String contains water: {0}", ourString.Contains("water"));



            Console.WriteLine(ourString.IndexOf("you"));
            Console.WriteLine(ourString.LastIndexOf("you"));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Program
    {
        private static string testString = "Mode";

        static void Main()
        {
            Console.WriteLine("This");
            Console.WriteLine();
            Console.WriteLine("Is");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(testString);


            int test = int.Parse(Console.ReadLine());
            
            Console.WriteLine(test);
        }
    }
}

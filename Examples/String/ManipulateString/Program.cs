using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "      Pesho Georgiev Dimitrov     ";

            string name1 = name.Replace("Georgiev", "Ivanov");

            Console.WriteLine(name.ToUpper() + "\\");

            Console.WriteLine(name1 + "//");

            Console.WriteLine(name.ToLower() + "//");

            Console.WriteLine(name.Trim() + "//");
            Console.WriteLine(name.TrimEnd() + "//");
            Console.WriteLine(name.TrimStart() + "//");
        }
    }
}

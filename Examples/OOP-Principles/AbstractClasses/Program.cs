using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction obj = new Abstraction();

            ChildClass child = new ChildClass("Aa", 5);
            Console.WriteLine(child.Name);
        }
    }
}

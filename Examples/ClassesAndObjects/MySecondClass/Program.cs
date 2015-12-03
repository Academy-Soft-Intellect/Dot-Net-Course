using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.Processor = "Intel";
            Console.WriteLine(myLaptop.Brand);

            myLaptop.Brand = "hp";
            Console.WriteLine(myLaptop.Brand);

            Console.WriteLine(myLaptop.Processor);

            Laptop alekssLaptop = new Laptop("HP");

            Console.WriteLine(alekssLaptop.Brand);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace FirstClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLaptop = new Laptop();
            firstLaptop.Price = 10;
            firstLaptop.Brand = "Test";
            //Console.WriteLine(firstLaptop.Price);
            //Console.WriteLine(firstLaptop.Brand);

            var secondLaptop = new Laptop("Test2", 15);
            //Console.WriteLine(secondLaptop.Brand);
            //Console.WriteLine(secondLaptop.Price);

            Laptop[] arrOfLaptops = new Laptop[] { firstLaptop, secondLaptop };

            foreach (var currentLaptop in arrOfLaptops)
            {
                currentLaptop.PrintInfo();
            }

            var empl = new Employee(12,12);
        }
    }
}

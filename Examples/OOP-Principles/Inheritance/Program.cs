using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.Male = true;
            //cat.Name = "Roki";
            
            //Console.WriteLine(cat.Male);
            //Console.WriteLine(cat.Name);

            //Cat cat2 = new Cat(false, "MMM");

            //Console.WriteLine(cat2.Male);
            //Console.WriteLine(cat2.Name);

            Lion lion = new Lion(true, 80);
            lion.Name = "Lion1";

            Cat cat1 = new Cat();
            cat1.Name = "Cat1";

            Console.WriteLine(lion.PrintInfo());


            Console.WriteLine(cat1.PrintInfo());




            //AfricanLion lion3 = new AfricanLion(true, 80, "orange");

            //Console.WriteLine(lion.Equals(lion2));
        }
    }
}

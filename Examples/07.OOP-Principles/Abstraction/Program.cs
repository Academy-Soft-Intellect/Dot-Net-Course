using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(true, 150);
            Cat bigCat1 = lion;
            Console.WriteLine(bigCat1.ToString());


            AfricanLion africanLion = new AfricanLion(true, 80, "orange");
            Cat bigCat2 = africanLion;

            Console.WriteLine(bigCat2.Male);
        }
    }
}

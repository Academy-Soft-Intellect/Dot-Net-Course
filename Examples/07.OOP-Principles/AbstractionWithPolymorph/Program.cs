using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithPolymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Goshko");
            dog.PrintInformation();

            Animal cat = new Cat("Toshko");
            cat.PrintInformation();
        }
    }
}

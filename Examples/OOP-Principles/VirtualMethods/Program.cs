using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(false);
            cat.CatchPray(null);

            Cat lion = new Lion(true, 80);
            lion.CatchPray(null);

            AfricanLion africanLion = new AfricanLion(true, 120);
            africanLion.CatchPray(null);
        }
    }
}

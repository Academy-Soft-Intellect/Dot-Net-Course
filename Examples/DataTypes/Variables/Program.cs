using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables demo
            int myAge = 7;
            int MyAge = 8;
            Console.WriteLine(myAge);
            Console.WriteLine(MyAge);

            //Cyrilic
            int Кола = 9;
            Console.WriteLine(Кола);

            //int 1best = 3; - Not working because of integer in the beginning of the variable

            //use of unassigned
            int y;
            //Console.WriteLine(y);
        }
    }
}

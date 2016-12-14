using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ourSecondArray = { 3451, 232, 3465465, 4 };

            foreach (int number in ourSecondArray)
            {
                Console.WriteLine(number);
            }

            foreach (var item in ourSecondArray)
            {
                Console.WriteLine(item + 5);
            }
        }
    }
}

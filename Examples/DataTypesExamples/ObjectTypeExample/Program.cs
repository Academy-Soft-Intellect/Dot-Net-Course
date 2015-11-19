using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            object myObject = 5;

            var myVariable = 5;
            Console.WriteLine(myVariable.GetType());

            var mySecondVariable = 5.5;
            Console.WriteLine(mySecondVariable.GetType());
        }
    }
}

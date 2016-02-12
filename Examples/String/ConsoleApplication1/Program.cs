using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile[] arr = new Automobile[10];

            for (int i = 0; i < arr.Length; i++)
            {
                (arr[i] as Car).Name = 231;
                ((Car)arr[i]).
            }
        }
    }
}

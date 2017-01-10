using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 2;
            arr[2] = 8;
            arr[3] = 22;
            arr[4] = 1;

            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

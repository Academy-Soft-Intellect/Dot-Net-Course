using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 7, 4, 9, 6, 10, 8, 2, 12 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            int m = int.Parse(Console.ReadLine());

            Array.Sort(arr);

            int index = Array.BinarySearch(arr, m);

            while (m == arr[index])
            {
                index++;
            }

            Console.WriteLine(arr[index]);
        }
    }
}

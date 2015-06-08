using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Source array that is ordered ascending.
            //
            //string[] array = { "a", "e", "m", "n", "x", "z" };
            ////
            //// Call versions of the BinarySearch method.
            ////
            //int index1 = Array.BinarySearch(array, "m");
            //int index2 = Array.BinarySearch<string>(array, "x");
            //int index3 = Array.BinarySearch<string>(array, "E", StringComparer.OrdinalIgnoreCase);
            ////
            //// Write results.
            ////
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);
            //Console.WriteLine(index3);

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = BinarySearch(arr, 5);

            Console.WriteLine(index);
        }


        static int BinarySearch(int[] array, int value)
        {
            int low = 0, high = array.Length - 1, midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                // check to see if value is equal to item in array
                if (value == array[midpoint])
                {
                    return midpoint;
                }
                else if (value < array[midpoint])
                    high = midpoint - 1;
                else
                    low = midpoint + 1;
            }

            // item was not found
            return -1;
        }
    }
}

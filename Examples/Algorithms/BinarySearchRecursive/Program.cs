using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchRecursive
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = BinarySearch(arr, 5, 0, arr.Length - 1);

            Console.WriteLine(index);
        }


        static int BinarySearch(int[] array, int value, int high, int low)
        {
            int midpoint = 0;

            midpoint = low + (high - low) / 2;

            // check to see if value is equal to item in array
            if (value == array[midpoint])
            {
                return midpoint;
            }
            else if (value < array[midpoint])
            {
                high = midpoint - 1;
                return BinarySearch(array, value, high, low);
            }
            else
            {
                low = midpoint + 1;
                return BinarySearch(array, value, high, low);
            }

            // item was not found
            return -1;
        }
    }
}

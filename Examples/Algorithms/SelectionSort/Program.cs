using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 64, 25, 12, 22, 11 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) // swap items
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++) // print sorted array
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

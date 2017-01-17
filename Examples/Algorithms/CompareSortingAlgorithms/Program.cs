using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000;

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, n);
            }

            int startArraySort = Environment.TickCount;
            Array.Sort(arr);
            Console.WriteLine("Array sort in miliseconds: " + (Environment.TickCount - startArraySort));

            int startQuickSort = Environment.TickCount;
            Quicksort(arr, 0, n-1);
            Console.WriteLine("Quick sort in miliseconds: " + (Environment.TickCount - startQuickSort));

            int startSelectionSort = Environment.TickCount;
            SelectionSort(arr);
            Console.WriteLine("Selection sort in miliseconds: " + (Environment.TickCount - startSelectionSort));

        }

        private static void SelectionSort(int[] array)
        {
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
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static List<int> RandomList(int size)
        {
            List<int> ret = new List<int>(size);
            Random rand = new Random(1);
            for (int i = 0; i < size; i++)
            {
                ret.Add(rand.Next(size));
            }
            return ret;
        }

        static void Main(string[] args)
        {
            int n = 6;

            // Create an unsorted array of string elements
            List<int> unsorted = RandomList(n);

            // Print the unsorted array
            for (int i = 0; i < n; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, n-1);

            // Print the sorted array
            for (int i = 0; i < n; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(List<int> elements, int left, int right)
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

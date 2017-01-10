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
            int n = 500;

            int[] array = new int[n];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, n);
            }

            int iterations = 0;

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
                    iterations++;
                }
            }
            for (int i = 0; i < array.Length; i++) // print sorted array
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Number of iterations: " + iterations);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static readonly int n = int.Parse(Console.ReadLine());

        static int[] array = new int[n];
        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + 1 + " ");
            }
            Console.WriteLine();
        }
        static void Permute(int k)
        {
            int i, swap;
            if (k == 0)
            {
                Print();
            }
            else
            {

                for (i = 0; i < k; i++)
                {
                    swap = array[i];
                    array[i] = array[k - 1];
                    array[k - 1] = swap;
                    Permute(k - 1);

                    swap = array[i];
                    array[i] = array[k - 1];
                    array[k - 1] = swap;

                }
            }
        }
        static void Main()
        {
            for (int i = 1; i < n; i++)
            {
                array[i] = i;
            }
            Console.WriteLine();
            Permute(n);
        }
    }
}

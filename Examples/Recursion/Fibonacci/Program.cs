using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[] arr = new int[n];

            Fibonacci(arr, 7);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static int Fibonacci(int[] arr, int n)
        {
            if (n<=1)
            {
                arr[n] = 1;
                return 1;
            }
            arr[n] = Fibonacci(arr, n - 1) + Fibonacci(arr, n - 2);
            Console.WriteLine(n);
            return arr[n];
        }
    }
}

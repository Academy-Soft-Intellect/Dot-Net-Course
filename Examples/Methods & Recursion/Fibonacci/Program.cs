using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            int count = 0;
            BigInteger[] arr = new BigInteger[n]; 

            Fibonacci(arr,n-1, ref count);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Number of operations: {0}", count);
        }
        static BigInteger Fibonacci(BigInteger[] arr, int n, ref int count)
        {
            if (n<=1)
            {
                arr[n] = 1;
                return 1;
            }
            count++;
            arr[n] = Fibonacci(arr, n - 1, ref count) + Fibonacci(arr, n - 2, ref count);
            //Console.WriteLine("SMQTAAAAAI");
            return arr[n];
        }
    }
}

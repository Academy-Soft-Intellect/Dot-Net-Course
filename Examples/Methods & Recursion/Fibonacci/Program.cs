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
            int n = 100;
            BigInteger[] arr = new BigInteger[n]; 

            Fibonacci(arr,n-1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static BigInteger Fibonacci(BigInteger[] arr, int n)
        {
            if (n<=1)
            {
                arr[n] = 1;
                return 1;
            }
            arr[n] = Fibonacci(arr, n - 1) + Fibonacci(arr, n - 2);
            Console.WriteLine("SMQTAAAAAI");
            return arr[n];
        }
    }
}

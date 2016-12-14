using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ourArray = new int[] { 1, 5, 2, 4, 5, 6, 7 };

            //for (int i = 0; i < ourArray.Length; i++)
            //{
            //    Console.WriteLine(ourArray[i]);
            //}

            //Console.WriteLine(ourArray.Length);

            //for (int index = 0; index < ourArray.Length; index++)
            //{
            //    if (index==3)
            //    {
            //        ourArray[index] = 123;
            //    }
            //    Console.WriteLine(ourArray[index]);
            //}
            //Console.WriteLine();
            //Console.WriteLine(ourArray.Length);

            //int[] ourSecondArray = { 1, 2, 3, 4 };
            //Console.WriteLine(ourSecondArray.Length);

            //Console.WriteLine("Enter array length");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Your arr is");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            string[] stringArr = new string[] { "ABV", "BVA", "PVC", "Dograma" };

            for (int i = 0; i < stringArr.Length; i++)
            {
                Console.WriteLine(stringArr[i]);
            }
        }
    }
}

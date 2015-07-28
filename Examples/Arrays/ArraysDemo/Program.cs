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
            //int[] ourArray = new int[] { 1, 5, 2, 4, 5, 6 };

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

            int[] arr = new int[5];
            arr[5] = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr[3]);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
    }
}

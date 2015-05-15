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
            //int[] ourArray = new int[6];

            //for (int index = 0; index < ourArray.Length; index++)
            //{
            //    Console.WriteLine(ourArray[index]);
            //}

            //int[] ourSecondArray = { 1, 2, 3, 4 };
            //Console.WriteLine(ourSecondArray.Length);

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
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

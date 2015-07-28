using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ourArray = new int[4, 3];

            //Console.WriteLine(ourArray.GetLength(0));

            //Console.WriteLine(ourArray.GetLength(1));

            //Console.WriteLine(ourArray.Length);

            //Console.WriteLine(ourArray[2, 1]);

            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int j = 0; j < ourArray.GetLength(1); j++)
                {
                    ourArray[i,j] = int.Parse(Console.ReadLine());
                }
            }


            //for (int i = 0; i < ourArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ourArray.GetLength(1); j++)
            //    {
            //        Console.Write(ourArray[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            foreach (var item in ourArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}

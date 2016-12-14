using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = 4;

            int[,] arr = new int[side, side];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        arr[i, j] = number;
                    }
                    else
                    {
                        arr[i, j] = number * 2;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

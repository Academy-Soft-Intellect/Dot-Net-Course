using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(1,100);
            }

            //List<int> list = new List<int>();

            //for (int i = 0; i < 11; i++)
            //{
            //    int current = rand.Next(1, 12);
            //    if (list.Contains(current))
            //    {
            //        i--;
            //    }
            //    else
            //    {
            //        list.Add(current);
            //    }
            //}

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}

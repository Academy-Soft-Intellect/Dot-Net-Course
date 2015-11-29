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

            List<int> list = new List<int>();

            for (int i = 0; i < 11; i++)
            {
                int current = rand.Next(1, 12);
                if (list.Contains(current))
                {
                    i--;
                }
                else
                {
                    list.Add(current);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}

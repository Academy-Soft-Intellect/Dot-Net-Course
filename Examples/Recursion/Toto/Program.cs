using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int counter = 0;

            Random rand = new Random();

            while (counter < 6)
            {
                int nextNumber = rand.Next(1, 50);
                if (!numbers.Contains(nextNumber))
                {
                    numbers[counter] = nextNumber; 
                    counter++;
                }
            }
            foreach (int number in numbers)
            {
                Console.Write(number+"\t");
            }
            Console.WriteLine();
        }
    }
}

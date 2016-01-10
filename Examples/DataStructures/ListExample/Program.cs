using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 11; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine(numbers.Capacity);
            Console.WriteLine(numbers.Count);
            numbers.Add(45);

            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);

            Console.WriteLine(numbers.Capacity);
            Console.WriteLine(numbers.Count);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();

            dict.Add(3, "Three");
            dict.Add(2, "One");
            dict.Add(5, "One");
            dict.Add(1, "Two");

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}
            dict.Add(4, "Four");
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}

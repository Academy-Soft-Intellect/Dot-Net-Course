using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();


            dict.Add(3, "Three");
            dict.Add(1, "One");
            dict.Add(4, "Four");
            dict.Add(2, "Two");
            dict[5] = "Five";

            for (int i = 0; i < 8; i++)
            {
                dict.Add(6 + i, "a");
            }

            string test;

            if (dict.TryGetValue(4, out test))
            {
                Console.WriteLine(test);
                Console.WriteLine("Success");
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

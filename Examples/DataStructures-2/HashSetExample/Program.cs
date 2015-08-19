using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "cat", "dog", "cat", "leopard", "tiger", "cat" };

            Console.WriteLine(string.Join(",", array1));

            HashSet<string> hash = new HashSet<string>(array1);

            string[] array2 = hash.ToArray();

            Console.WriteLine(string.Join(",", array2));

            hash.Add("dog");

            array2 = hash.ToArray();

            Console.WriteLine(string.Join(",", array2));

        }
    }
}

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
            //int[] array2 = { 1,4,2,6,9,4,8 };

            Console.WriteLine(string.Join(",", array1));

            var list = array1.ToList();

            HashSet<string> hash = new HashSet<string>(array1);

            hash.Add("dog");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }


            string isTrue = 1 == 2 ? "Brao genii" : "Tapak";

            //Console.WriteLine(isTrue);

            string[] array2 = hash.ToArray();

            Console.WriteLine(string.Join(",", array2));

            hash.Add("pes");

            array2 = hash.ToArray();

            Console.WriteLine(string.Join(",", array2));

        }
    }
}

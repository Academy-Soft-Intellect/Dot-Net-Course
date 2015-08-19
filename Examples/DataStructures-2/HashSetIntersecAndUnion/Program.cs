using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetIntersecAndUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int[] array2 = new int[] { 4, 5, 6, 7, 8, 9, 10 };

            int[] array3 = new int[] { 4, 5, 6, 7, 8, 9, 10 };


            HashSet<int> hash1 = new HashSet<int>(array1);
            HashSet<int> hash2 = new HashSet<int>(array2);
            HashSet<int> hash3 = new HashSet<int>(array3);

            int[] intersectResult = hash1.Intersect(hash2).ToArray();

            foreach (var item in intersectResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            int[] unionResult = hash1.Union(hash3).ToArray();

            foreach (var item in unionResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

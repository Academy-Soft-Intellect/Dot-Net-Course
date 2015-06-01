using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> test = new Dictionary<string, int>();

            test.Add("cat", 2);
            test.Add("dog", 1);
            test.Add("llama", 0);
            test.Add("iguana", -1);

            if (test.ContainsKey("cat"))
            {
                test["cat"]++;
            }

        }
    }
}

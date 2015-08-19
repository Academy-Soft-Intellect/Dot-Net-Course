using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Entry number One");
            queue.Enqueue("Entry number Two");
            queue.Enqueue("Entry number Three");
            queue.Enqueue("Entry number Four");
            while (queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }

        }
    }
}

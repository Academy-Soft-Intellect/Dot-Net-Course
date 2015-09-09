using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreads
{
    class ThreadClass
    {
        public void DoTask1()
        {
            int start = Environment.TickCount;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1:job({0})", i);
                Thread.Sleep(50);
            }
            Console.WriteLine("Time taken: " + (Environment.TickCount - start));
        }

        public void DoTask2()
        {
            int start = Environment.TickCount;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2:job({0})", i);
                Thread.Sleep(50);
            }
            Console.WriteLine("Time taken: " + (Environment.TickCount - start));
        }
    }
}

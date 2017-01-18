using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace JoinThreads
{
    class ThreadClass
    {
        public void DoTask1()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    //Thread.Sleep(5);
                }
                Console.WriteLine("Thread1:job({0})", i);
            }
        }

        public void DoTask2()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    //Thread.Sleep(5);
                }
                Console.WriteLine("Thread2:job({0})", i);
            }
        }
    }
}

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
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    Console.WriteLine("Thread1:job({0})", i);
                    //Thread.Sleep(5);
                }
            }
        }

        public void DoTask2()
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    Console.WriteLine("Thread2:job({0})", i);
                    //Thread.Sleep(5);
                }
            }
        }
    }
}

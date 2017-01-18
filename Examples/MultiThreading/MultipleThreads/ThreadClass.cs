using System;
using System.Threading;

namespace MultipleThreads
{
    class ThreadClass
    {
        public string ThreadName { get; set; }

        public ThreadClass(string name)
        {
            this.ThreadName = name;
        }

        public void DoTask1()
        {
            int start = Environment.TickCount;
            var counter = 0;
            //Console.WriteLine("First thread ID is :" + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10000; k++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("Thread1:job({0})", i);
                //Thread.Sleep(3);
            }
            Console.WriteLine("Time taken for first thread: " + (Environment.TickCount - start));
        }

        public void DoTask2()
        {
            int start = Environment.TickCount;
            var counter = 0;
            //Console.WriteLine("Second thread ID is :" + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10000; k++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("Thread2:job({0})", i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Time taken for second thread: " + (Environment.TickCount - start));
        }

        public void DoTask3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("{0}:{1}", this.ThreadName, i);
            }
        }
    }
}

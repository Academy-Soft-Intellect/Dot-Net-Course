using System;
using System.Threading;

namespace MultipleThreads
{
   class Program
    {
        static void Main(string[] args)
        {

            int start = Environment.TickCount;

            ThreadClass threadClass = new ThreadClass("Thread 1");
            Console.WriteLine("Main thread ID is :"+ Thread.CurrentThread.ManagedThreadId);
            //threadClass.DoTask1();
            //threadClass.DoTask2();


            Thread thread1 = new Thread(
               new ThreadStart(new ThreadClass("ONE").DoTask1));

            Thread thread2 = new Thread(
               new ThreadStart(threadClass.DoTask2));

            thread2.Priority = ThreadPriority.Highest;
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();

            Console.WriteLine("Time taken: " + (Environment.TickCount - start));
        }
    }

    
}

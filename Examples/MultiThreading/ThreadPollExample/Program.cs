using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPollExample
{
    class Program
    {
        const int TASKS_COUNT = 30;

        public static void LongTask(object aParam)
        {

            Console.WriteLine("Started: {0}.", aParam);
            Thread.Sleep(500);
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Finished: {0}.", aParam);
        }

        static void Main()
        {
            Console.WriteLine("Press [Enter] to exit.");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 1; i <= TASKS_COUNT; i++)
            {
                string taskName = "Task " + i;
                //ThreadPool.SetMinThreads(8, 8);
                ThreadPool.QueueUserWorkItem(new
                   WaitCallback(LongTask), taskName);
            }

            Console.ReadLine();
        }
    }
}

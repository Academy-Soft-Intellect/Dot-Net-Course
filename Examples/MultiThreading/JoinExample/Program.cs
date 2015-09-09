using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinExample
{
    class Program
    {
        static Thread mainThread, thread1, thread2;

        public static void Main()
        {
            mainThread = Thread.CurrentThread;
            thread1 = new Thread(ThreadProc);
            thread1.Name = "Thread1";
            Console.WriteLine(1);
            thread1.Start();
            Console.WriteLine(2);

            thread2 = new Thread(ThreadProc);
            thread2.Name = "Thread2";
            Console.WriteLine(3);
            thread2.Start();
            Console.WriteLine(4);

        }

        private static void ThreadProc()
        {

            Console.WriteLine(5);
            Console.WriteLine("Current thread: {0}", Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == "Thread1" &&
                thread2.ThreadState != ThreadState.Unstarted)
            {

                Console.WriteLine(5.1);
                Console.WriteLine("Joined");
                thread2.Join();
                Console.WriteLine(5.12);
            }
            else
            {
                Console.WriteLine(5.2);
                Console.WriteLine("Current thread is 2");
            }

            Console.WriteLine(6);
            Console.WriteLine("Current thread: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Thread1: {0}", thread1.ThreadState);
            Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
            Console.WriteLine(7);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreads
{
   class Program
    {
        static void Main(string[] args)
        {

            int start = Environment.TickCount;

            ThreadClass threadClass = new ThreadClass();

            threadClass.DoTask1();
            threadClass.DoTask2();


            //Thread thread1 = new Thread(
            //   new ThreadStart(threadClass.DoTask1));

            //Thread thread2 = new Thread(
            //   new ThreadStart(threadClass.DoTask2));

            //thread1.Start();
            //thread2.Start();

            Console.WriteLine("Time taken: " + (Environment.TickCount - start));
        }
    }

    
}

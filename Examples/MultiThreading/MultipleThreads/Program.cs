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
            ThreadClass threadClass = new ThreadClass();

            Thread thread1 = new Thread(
               new ThreadStart(threadClass.DoTask1));

            Thread thread2 = new Thread(
               new ThreadStart(threadClass.DoTask2));

            thread1.Start();
            thread2.Start();
        }
    }

    
}

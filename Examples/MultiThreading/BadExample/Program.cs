using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Environment.TickCount;

            Console.WriteLine("Thread started");
            Thread t = new Thread(new ThreadStart(new TimeTakingJob().Job));
            t.Start();

            Thread mainThread = Thread.CurrentThread;
            Thread.Sleep(1300);

            //Console.WriteLine("Job started");
            //TimeTakingJob job = new TimeTakingJob();
            //job.Job();
            
            Console.WriteLine("Time taken: " + (Environment.TickCount - start));
            
        }
    }
}

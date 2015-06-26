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
            //TimeTakingJob job = new TimeTakingJob();
            //job.Job();

            Thread t = new Thread(new ThreadStart(new TimeTakingJob().Job));
            t.Start();
            Console.WriteLine(Environment.TickCount - start);
            
        }
    }
}

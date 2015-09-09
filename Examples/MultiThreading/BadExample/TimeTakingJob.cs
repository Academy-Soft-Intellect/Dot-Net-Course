using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadExample
{
    class TimeTakingJob
    {
        public void Job()
        {
            long sum = 0;
            for (int i = 0; i < 20000; i++)
            {
                for (int j = 0; j < 20000; j++)
                {
                    if (i == j)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine("Finished");
        }
    }
}

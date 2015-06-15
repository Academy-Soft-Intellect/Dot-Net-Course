using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreeThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Thread thread1 = new Thread(new ThreadClass("ONE", rand).PrintInfo);

            Thread thread2 = new Thread(new ThreadClass("TWO", rand).PrintInfo);

            Thread thread3 = new Thread(new ThreadClass("THREE", rand).PrintInfo);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}

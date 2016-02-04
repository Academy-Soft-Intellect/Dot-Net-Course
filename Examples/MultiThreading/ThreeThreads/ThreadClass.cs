using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreeThreads
{
    public class ThreadClass
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int sleep;
        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }


        public ThreadClass(string name, Random rand)
        {
            this.name = name;
            this.sleep = rand.Next(600);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Thread {0} started!", Name);
            Thread.Sleep(sleep);
            Console.WriteLine("Thread {0} stopped, after {1} miliseconds sleep", Name, sleep);

        }
    }
}

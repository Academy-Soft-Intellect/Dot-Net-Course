using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuspendAndResume
{
    class Program
    {
        private Thread mThread;

        private const string MESSAGE = "This application demonstrates " + "Thread.Suspend() and Thread.Resume() methods. ";

        private void Main(string[] args)
        {
            mThread = new Thread(new ThreadStart(this.PrintMessages));
            mThread.IsBackground = true;
            mThread.Start();
            SuspendThread();
            SpendSomeTime();
            ResumeThread();
        }

        private void SpendSomeTime()
        {
            long sum = 0;
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    if (i == j)
                    {
                        sum++;
                    }
                }
            }
        }

        private void SuspendThread()
        {
            mThread.Suspend();
        }

        private void ResumeThread()
        {
            mThread.Resume();
        }

        private void PrintMessages()
        {
            while (true)
            {
                foreach (char letter in MESSAGE.ToCharArray())
                {
                    Console.WriteLine(letter);
                    Thread.Sleep(50);
                }
            }
        }
    }
}

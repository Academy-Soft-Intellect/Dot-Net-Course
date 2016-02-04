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
        private static Thread mThread;

        private const string MESSAGE = "This application demonstrates";

        private static void Main()
        {
            mThread = new Thread(new ThreadStart(PrintMessages));
            mThread.Start();
            for (int i = 0; i < 10; i++)
            {
                SpendSomeTime();
                mThread.Suspend();
                Console.WriteLine();
                Console.WriteLine();
                SpendSomeTime();
                mThread.Resume();
            }
            mThread.Suspend();
        }

        private static void SpendSomeTime()
        {
            long sum = 0;
            for (int i = 0; i < 15000; i++)
            {
                for (int j = 0; j < 15000; j++)
                {
                    if (i == j)
                    {
                        sum++;
                    }
                }
            }
        }

        private static void PrintMessages()
        {
            while (true)
            {
                foreach (char letter in MESSAGE.ToCharArray())
                {
                    Console.Write(letter);
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
            
        }
    }
}

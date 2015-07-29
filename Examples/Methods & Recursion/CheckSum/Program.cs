using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 14;
            int[] numbers = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };

            bool[] checkSum = new bool[s + 1];
            bool[] alreadySet = new bool[checkSum.Length];
            foreach (int item in numbers)
            {
                if (item > s)
                {
                    continue;
                }
                for (int i = 0; i < checkSum.Length; i++)
                {
                    if (item + i > checkSum.Length - 1)
                    {
                        continue;
                    }
                    if (alreadySet[i] == true)
                    {
                        checkSum[i + item] = true;
                    }
                }
                checkSum[item] = true;
                Array.Copy(checkSum, alreadySet, checkSum.Length);
            }

        }
    }
}

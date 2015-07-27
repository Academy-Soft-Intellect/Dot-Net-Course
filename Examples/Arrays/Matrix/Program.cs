using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ourArray = new int[,] {
                                            {13, 2, 2333},
                                            {42, 3432, 623 },
                                            {17, 118, 911},
                                            {1330, 112, 123}
                                        };

            //Console.WriteLine(ourArray.GetLength(0));

            //Console.WriteLine(ourArray.GetLength(1));

            //Console.WriteLine(ourArray.Length);

            Console.WriteLine(ourArray[2, 1]);



            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int j = 0; j < ourArray.GetLength(1); j++)
                {
                    //ourArray[i,j] = 
                }
            }


        }
    }
}

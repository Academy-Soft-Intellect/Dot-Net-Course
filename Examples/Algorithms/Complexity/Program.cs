using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] arr = new int[n];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0,n);
            }

            int startLinear = Environment.TickCount;
            FindMaxElement(arr);
            Console.WriteLine("Linear time in miliseconds: " + (Environment.TickCount - startLinear));


            int quadratic = Environment.TickCount;
            FindInversions(arr);
            Console.WriteLine("Quadratic time in miliseconds: " + (Environment.TickCount - quadratic));



            int cubic = Environment.TickCount;
            Sum3(n);
            Console.WriteLine("Cubic time in miliseconds: " + (Environment.TickCount - cubic));

        }

        //Линейна сложност - Този код ще работи добре, дори при голям брой елементи.
        static int FindMaxElement(int[] array)
        {
            int max = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //Квадратична сложност - Този код ще работи добре, ако елементите не са повече от няколко хиляди или десетки хиляди.
        static int FindInversions(int[] array)
        {
            int inversions = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        inversions++;
                    }
                }
            }
            return inversions;
        }


        //Кубична сложност - Този код ще работи добре, ако елементите в масива са под 1 000.
        static long Sum3(int n)
        {
            long sum = 0;
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 1; c < n; c++)
                    {
                        sum += a * b * c;
                    }
                }
            }
            return sum;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point(2, 3);
            double myPointXCoordinate = myPoint.X; 
            double myPointYCoordinate = myPoint.Y; 
            Console.WriteLine("The X coordinate is: " +
            myPointXCoordinate);
            Console.WriteLine("The Y coordinate is: " +
            myPointYCoordinate);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Point
    {
        private double x;
        private double y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        //private double[] coordinates;
        //public Point(int xCoord, int yCoord)
        //{
        //    this.coordinates = new double[2];
        //    // Initializing the x coordinate
        //    coordinates[0] = xCoord;
        //    // Initializing the y coordinate
        //    coordinates[1] = yCoord;
        //}
        //public double X
        //{
        //    get { return coordinates[0]; }
        //    set { coordinates[0] = value; }
        //}
        //public double Y
        //{
        //    get { return coordinates[1]; }
        //    set { coordinates[1] = value; }
        //}

    }
}

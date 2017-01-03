using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle()
            {
                Height = 5,
                Side = 4,
                Name = "Triangle 1"
            };
            triangle.CalculateArea();
            triangle.Display();

            var rectangle = new Rectangle()
            {
                SideA = 3,
                SideB = 6,
                Name = "Rectangle 1"
            };
            rectangle.CalculateArea();
            rectangle.Display();
        }
    }
}

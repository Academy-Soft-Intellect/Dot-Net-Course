using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithShapes
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine(this.SideA * this.SideB);
        }

        public override void Display()
        {
            Console.WriteLine("Rectangle {0} displayed", this.Name);
        }
    }
}

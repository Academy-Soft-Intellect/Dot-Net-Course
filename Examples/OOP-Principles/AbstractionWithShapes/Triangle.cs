using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithShapes
{
    public class Triangle : Shape
    {
        public double Side { get; set; }

        public double Height { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine(this.Side * this.Height / 2);
        }

        public override void Display()
        {
            Console.WriteLine("Triangle {0} displayed", this.Name);
        }
    }
}

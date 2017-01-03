using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithShapes
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract void CalculateArea();

        public abstract void Display();
    }
}

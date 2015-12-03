using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Vehicle()
        { }
        public Vehicle(string price, string color)
        {
            this.Price = price;
            this.Color = color;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Price);
            Console.WriteLine(this.Color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassAndObject
{
    public class Laptop
    {
        public string Brand { get; set; }

        public int Price { get; set; }

        public Laptop()
        {
        }

        public Laptop(string brand, int price)
        {
            this.Brand = brand;
            this.Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This laptops is {0} and costs {1}", this.Brand, this.Price);
        }
    }
}

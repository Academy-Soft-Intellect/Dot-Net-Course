using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("$$$", "Blue", "Mercedes");

            Car yourCar = new Car("$$$", "Red", "Audi");

            Console.WriteLine("My car is a {0} {1} and costs {2}", myCar.Color, myCar.Model, myCar.Price);

            Console.WriteLine("Your car is a {0} {1} and costs {2}", yourCar.Color, yourCar.Model, yourCar.Price);
        }
    }
}

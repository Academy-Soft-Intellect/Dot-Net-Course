using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobilesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Automobile[4];

            for (int i = 0; i < 2; i++)
            {
                arr[i] = new Car()
                {
                    Price = double.Parse(Console.ReadLine()),
                    FuelConsumption = double.Parse(Console.ReadLine())
                };
            }

            for (int i = 2; i < 4; i++)
            {
                arr[i] = new Suv()
                {
                    Price = double.Parse(Console.ReadLine()),
                    High = bool.Parse(Console.ReadLine())
                };
            }

            foreach (var currentObject in arr)
            {
                if (currentObject.GetType() == typeof(Car))
                {
                    var car = currentObject as Car;
                    Console.WriteLine(car.FuelConsumption);
                    Console.WriteLine(car.Price);
                }
                else if (currentObject is Suv)
                {
                    Console.WriteLine((currentObject as Suv).High);
                    Console.WriteLine((currentObject as Suv).Price);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle veh = new Vehicle(200, 4);

            //Console.WriteLine(veh);

            Car car = new Car(200, 5, "Lada", "Niva");
            //Console.WriteLine(car);

            Bus bus = new Bus(160, 3, 3, 1500);
            //Console.WriteLine(bus);


            Console.WriteLine(car.CalculateMaxSpeed());

            Console.WriteLine(bus.CalculateMaxSpeed());

            Console.WriteLine(Car.tiresBrand);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfaces
{
    public class Person : IDriver, IMechanic
    {
        public void DriveCar()
        {
            Console.WriteLine("Drive the car");
        }

        public void FixCars()
        {
            Console.WriteLine("Fix the car");
        }
    }
}

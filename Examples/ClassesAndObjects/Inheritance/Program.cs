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
            Vehicle myV = new Vehicle();
            myV.Price = "200";
            myV.Color = "Blue";
            myV.PrintInfo();

            Car myCar = new Car();
            myCar.Price = "300";
            myCar.Color = "red";
            myCar.Model = "sdasda";
            myCar.PrintInfo();
            //MotorBike bike = new MotorBike();
            //bike.
        }
    }
}

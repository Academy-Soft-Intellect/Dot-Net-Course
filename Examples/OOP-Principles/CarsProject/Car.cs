using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Car : Vehicle
    {
        public static string tiresBrand = "Continental";

        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car(int maxSpeed, int numberOfSeats, string brand, string model)
            :base(maxSpeed, numberOfSeats)
        {
            this.brand = brand;
            this.model = model;
        }

        protected override string PrintInfo()
        {
            return "This vehicle is a car and has a top speed " + this.MaxSpeed 
                + " and has " + NumberOfSeats + " seats!" + 
                "And it is also a " + brand + " " + model; 
        }

    }
}

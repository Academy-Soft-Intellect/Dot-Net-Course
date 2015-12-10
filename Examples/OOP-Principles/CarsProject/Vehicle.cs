using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    abstract class Vehicle
    {
        private int maxSpeed;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        private int numberOfSeats;
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }

        public Vehicle(int maxSpeed, int numberOfSeets)
        {
            this.maxSpeed = maxSpeed;
            this.numberOfSeats = numberOfSeets;
        }

        public override string ToString()
        {
            //return "This vehicle has a top speed " + this.maxSpeed + " and has " + this.numberOfSeats + " seats!"; 
            return PrintInfo();
        }

        protected abstract String PrintInfo();
    }
}

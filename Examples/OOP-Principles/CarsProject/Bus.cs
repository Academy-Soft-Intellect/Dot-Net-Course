using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Bus : Vehicle, IVehicle
    {
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Bus(int maxSpeed, int numberOfSeats, int weight, int capacity)
            :base(maxSpeed, numberOfSeats)
        {
            this.weight = weight;
            this.capacity = capacity;
        }

        protected override string PrintInfo()
        {
            return "This vehicle is a bus and has a top speed " + this.MaxSpeed 
                + " and has " + NumberOfSeats + " seats!" + 
                "And it is also " + weight + " tons of weight and has " + capacity + " capacity"; 
        }

        public int CalculateMaxSpeed()
        {
            return this.capacity*this.weight;
        }


        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}

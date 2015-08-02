using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Vehicle
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car(string price, string color)
            : base(price, color)
        {
            this.Model = model;
        }
    }
}

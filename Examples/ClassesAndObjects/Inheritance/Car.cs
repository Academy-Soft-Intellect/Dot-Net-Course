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

        public Car(string price, string color, string model)
            :base(price,color)
        {
            this.model = model;
        }
    }
}

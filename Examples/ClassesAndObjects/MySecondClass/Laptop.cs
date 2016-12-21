using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondClass
{
    class Laptop
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value + "additionalValue"; }
        }

        private string processor;
        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        private int battery;
        public int Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Laptop()
        {
            this.brand = "No brand";
        }

        public Laptop(string brand)
        {
            this.brand = brand;
        }
    }
}

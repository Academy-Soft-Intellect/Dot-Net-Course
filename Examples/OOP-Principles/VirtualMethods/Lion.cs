using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Lion : Cat
    {
        private int weight;

        public Lion(bool male, int weight)
            : base(male)
        {
            this.weight = weight;
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public bool Equals(Lion lion)
        {
            if (this.Weight == lion.Weight &&
                this.Male == lion.Male)
            {
                return true;
            }
            else
                return false;
        }

        public override void CatchPray(object pray)
        {
            Console.WriteLine("Lion.CatchPray " + this.Male);
        }

    }
}

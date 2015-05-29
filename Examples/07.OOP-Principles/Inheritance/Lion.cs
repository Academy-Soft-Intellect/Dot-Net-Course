using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Lion : Cat, IEquatable<Lion>
    {
        private int weight;
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
        public Lion(bool male, int weight)
            :base(male)
        {
            this.weight = weight;
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

        public override string ToString()
        {
            return string.Format("Male: {0}, weight: {1}", Male, Weight);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class AfricanLion:Lion, IEquatable<AfricanLion>
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
       
        public AfricanLion(bool male, int weight, string color)
            : base(male, weight)
        {
            this.color = color;
        }

        public bool isEqual(AfricanLion afrLion)
        {
            if (this.Weight == afrLion.Weight &&
                this.Male == afrLion.Male && 
                this.Color == afrLion.Color)
            {
                return true;
            }
            else
                return false;
        }


        public override string ToString()
        {
            return string.Format(
            "AfricanLion, male: {0}, weight: {1}, color: {2}",
            this.Male, this.Weight, this.Color);
        }
    }
}

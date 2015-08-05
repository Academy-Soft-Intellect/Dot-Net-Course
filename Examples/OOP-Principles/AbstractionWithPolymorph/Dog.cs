using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithPolymorph
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            this.Name = name;
        }

        protected override String GetTypicalSound()
        {
            return "Bau! I am" +this.Name ;
        }

    }
}

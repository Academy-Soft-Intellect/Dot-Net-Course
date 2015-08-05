using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithPolymorph
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            this.Name = name;
        }
        protected override string GetTypicalSound()
        {
            return "Мяу! I am" + this.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Cat
    {
        private bool male;
        public Cat() : this(true) { }
        public Cat(bool male)
        {
            this.male = male;
        }
        public bool Male
        {
            get
            {
                return male;
            }
            set
            {
                this.male = value;
            }
        }

        public virtual void CatchPray(object pray)
        {
            Console.WriteLine("Cat.CatchPray");
        }

    }
}

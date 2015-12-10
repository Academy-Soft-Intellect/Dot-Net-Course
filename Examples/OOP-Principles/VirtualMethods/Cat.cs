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
        public bool Male
        {
            get { return male; }
            set { male = value; }
        }
        
        public Cat() : this(true) { }
        public Cat(bool male)
        {
            this.male = male;
        }

        public virtual void CatchPray(object pray)
        {
        }

    }
}

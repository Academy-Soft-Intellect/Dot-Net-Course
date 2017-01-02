using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat
    {
        private bool male;
        public bool Male
        {
            get { return male; }
            set { male = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Cat() 
        { 
        }

        public Cat(bool male)
        {
            this.male = male;
        }
        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(bool male, string name)
        {
            this.male = male;
            this.name = name;
        }

        public virtual string PrintInfo()
        {
            return string.Format(this.Name);
        }
    }
}

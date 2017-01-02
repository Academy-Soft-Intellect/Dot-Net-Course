using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithPolymorph
{
    public abstract class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string name)
        {
            this.name = name;
        }

        internal void PrintInformation()
        {
            Console.WriteLine("I am {0}.", this.GetType().Name);
            Console.WriteLine(GetTypicalSound());
        }
        protected abstract String GetTypicalSound();
    }

}

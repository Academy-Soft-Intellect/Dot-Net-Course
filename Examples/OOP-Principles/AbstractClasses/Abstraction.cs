using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Abstraction : IAbstractable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Abstraction()
        {

        }

        public Abstraction(string name)
        {
            this.name = name;
        }

        public abstract string PrintInfo();


        public abstract string PrintResult();

        private void Calculate()
        {
            Console.WriteLine(this.name);
        }
    }
}

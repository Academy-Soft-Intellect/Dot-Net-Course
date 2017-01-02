using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class ChildClass : Abstraction
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public ChildClass(string name, int age)
            : base(name)
        {
            this.age = age;
            DoubleName();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }

        public override string PrintResult()
        {
            throw new NotImplementedException();
        }

        private void DoubleName()
        {
            this.Name += 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsExample
{
    class MyClass
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public MyClass()
        {
            this.name = Constants.myString;
        }
    }
}

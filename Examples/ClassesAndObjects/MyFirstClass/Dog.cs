using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    class Dog
    {
        public static string Poroda = "Huskey";

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public Dog()
        {
            this.name = "Unnamed";
        }
        public Dog(string name)
        {
            this.name = name;
        }

        public void SayBau()
        {
            Console.WriteLine("Dog {0} said: BAUUUUU",name);
        }

    }
}

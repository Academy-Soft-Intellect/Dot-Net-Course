using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    public class Dog
    {
        public static string Poroda = "Huskey";

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public Dog()
        {
            this.name = "Unnamed";
            this.color = "White";
            this.age = 0;
        }
        public Dog(string newName)
        {
            this.name = newName;
        }

        public void SayBau()
        {
            Console.WriteLine("Dog {0} said: BAUUUUU. {0} is {1} year old"
                ,name, age);
        }

    }
}

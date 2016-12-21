using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Email: {2}", this.Name, this.Age, this.Email);
        }
    }
}

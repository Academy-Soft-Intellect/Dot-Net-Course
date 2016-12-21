using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTouchWithClassesAndObjects
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }

        public static int Counter;

        public Person()
        {
            Counter++;
        }

        public Person(string name, int age, string job)
        {
            this.Name = name;
            this.Age = age;
            this.Job = job;

            Counter++;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Job: {0}", this.Job);
        }

        public static void PrintInfo(Person person)
        {
            Console.WriteLine("Name: {0}", person.Name);
            Console.WriteLine("Age: {0}", person.Age);
            Console.WriteLine("Job: {0}", person.Job);
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} years old and is a {2}!", this.Name, this.Age, this.Job);
        }
    }
}

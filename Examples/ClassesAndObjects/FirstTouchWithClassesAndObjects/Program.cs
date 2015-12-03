using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTouchWithClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivaylo = new Person();
            Ivaylo.Age = 24;
            Ivaylo.Name = "Ivaylo";
            Ivaylo.Job = "DEv";
            Console.WriteLine(Ivaylo.Age);
            Console.WriteLine(Ivaylo.Name);
            Console.WriteLine(Ivaylo.Job);

            Person Giorgos = new Person();
            Giorgos.Age = 25;
            Giorgos.Name = "Gosho";
            Giorgos.Job = "Student";
            Giorgos.PrintPersonInfo();


            Person Stanislav = new Person("Stanislav", 19, "Student");
            Person.PrintInfo(Stanislav);


            Console.WriteLine(Ivaylo);

            Console.WriteLine("We have created {0} people!", Person.Counter);

        }
    }
}

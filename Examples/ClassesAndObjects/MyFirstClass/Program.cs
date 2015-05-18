using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Ben");
            dog1.Color = Constants.myConstant;
            dog1.Age = 2;


            Dog dog2 = new Dog();
            //dog2.Name = "Jack";
            //dog2.Color = "Black";
            //dog2.Age = 5;


            //dog2.SayBau();
            //dog1.SayBau();
            //Console.WriteLine(dog2.Age);

            Dog[] arrayOfDogs = new Dog[2];
            arrayOfDogs[0] = dog1;
            arrayOfDogs[1] = dog2;

            foreach (Dog item in arrayOfDogs)
            {
                item.SayBau();
            }

            //Dog.Poroda;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADogIsAnAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var jackTheAnimal = new Animal()
            {
                IsAMamal = true,
                Weight = 10
            };
            jackTheAnimal.Speak();

            var jackTheDog = new Dog()
            {
                Age = 8,
                IsAMamal = true,
                Weight = 40,
            };
            jackTheDog.Speak();

            var jackThePitbull = new Pitbull()
            {
                Age = 5,
                IsAMamal = true,
                Name = "Jack",
                Weight = 20,
            };
            jackThePitbull.Speak();
        }
    }
}

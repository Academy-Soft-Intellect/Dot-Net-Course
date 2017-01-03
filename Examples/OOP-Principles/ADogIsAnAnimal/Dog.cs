using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADogIsAnAnimal
{
    public class Dog : Animal
    {
        public int Age { get; set; }

        protected int NumberOfTeeth { get; set; }

        public override void Speak()
        {
            Console.WriteLine("I'm a dog");
        }
    }
}

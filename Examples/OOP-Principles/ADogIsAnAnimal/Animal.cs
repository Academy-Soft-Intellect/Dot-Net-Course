using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADogIsAnAnimal
{
    public class Animal
    {
        public bool IsAMamal { get; set; }

        public double Weight { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("I'm an animal");
        }
    }
}

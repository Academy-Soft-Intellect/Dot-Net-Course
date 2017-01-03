using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADogIsAnAnimal
{
    internal class Pitbull : Dog
    {
        public string Name { get; set; }

        public override void Speak()
        {
            Console.WriteLine("I'm a pitbull with {0}", NumberOfTeeth);
        }
    }
}

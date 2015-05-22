using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithPolymorph
{
    public class Dog : Animal
    {
        protected override String GetTypicalSound()
        {
            return "Bau!";
        }
    }
}

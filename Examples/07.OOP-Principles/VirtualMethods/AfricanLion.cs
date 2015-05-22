using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class AfricanLion: Lion
    {
        public AfricanLion(bool male, int weight)
            : base(male, weight)
        { }
        public override string ToString()
        {
            return string.Format(
            "(AfricanLion, male: {0}, weight: {1})",
            this.Male, this.Weight);
        }
        public override void CatchPray(object pray)
        {
            Console.WriteLine("AfricanLion.CatchPray");
        }
    }
}

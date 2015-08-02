using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Policeman : Employee
    {
        private string rang;

        public string Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Policeman(int workingHours, int payment, string rang)
            : base(workingHours, payment)
        {
            this.rang = rang;
        }

        public void PrintPolicemanInfo()
        {
            Console.WriteLine("{0} {1} {2}",WorkingHours, Payment, rang);
        }

    }
}

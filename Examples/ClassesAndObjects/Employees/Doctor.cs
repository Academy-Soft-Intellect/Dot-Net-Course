using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Doctor : Employee
    {
        private int nightShifts;
        public int NightShifts
        {
            get { return nightShifts; }
            set { nightShifts = value; }
        }

        public Doctor(int workingHours, int payment, int nightShifts)
            : base(workingHours, payment)
        {
            this.nightShifts = nightShifts;
        }

        public void PrintDoctorInfo()
        {
            Console.WriteLine("{0} {1} {2}", WorkingHours, Payment, nightShifts);
        }

    }
}

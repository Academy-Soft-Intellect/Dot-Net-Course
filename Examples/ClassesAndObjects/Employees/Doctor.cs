using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Doctor : Employee
    {
        public int NightShifts { get; set; }

        public Doctor(int hours, int salaray, int shifts) : base()
        {
            this.HoursPerMonth = hours;
            this.Salary = salaray;
            this.NightShifts = shifts;
        }

        public void PrintDoctorInfo()
        {
            Console.WriteLine("{0} {1} {2}", this.HoursPerMonth, this.Salary, this.NightShifts);
        }

    }
}

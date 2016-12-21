using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        private int workingHours;
        public int WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        private int payment;
        public int Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public Employee(int workingHours, int payment)
        {
            this.workingHours = workingHours;
            this.payment = payment;
        }
    }
}

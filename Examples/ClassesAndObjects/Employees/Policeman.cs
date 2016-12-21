using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Policeman : Employee
    {
        public string Rank { get; set; }

        public Policeman(int hours, int salaray, string rank) : base()
        {
            this.HoursPerMonth = hours;
            this.Salary = salaray;
            this.Rank = rank;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Hours: {0}, Salary: {1}, Rank: {2}", this.HoursPerMonth, this.Salary, this.Rank);
        }
    }
}

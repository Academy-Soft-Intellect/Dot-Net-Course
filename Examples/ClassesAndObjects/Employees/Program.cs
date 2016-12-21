using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Policeman polizei = new Policeman(8, 1000, "Captain");
            polizei.PrintPolicemanInfo();

            Doctor doctor = new Doctor(8, 800, 10);
            doctor.PrintDoctorInfo();
        }
    }
}

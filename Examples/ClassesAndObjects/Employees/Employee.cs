﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee : Person
    {
        public int HoursPerMonth { get; set; }

        public double Salary { get; set; }
    }
}

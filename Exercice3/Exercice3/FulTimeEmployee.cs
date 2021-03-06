﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class FulTimeEmployee : Employee
    {
        public double monthlySalary { get; set; }
        public FulTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }
        public override double getMonthSalary()
        {
            return monthlySalary;
        }
    }
}

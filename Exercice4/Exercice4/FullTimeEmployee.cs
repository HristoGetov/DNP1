using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class FullTimeEmployee:Employee
    {
        public double monthlySalary { get; set; }
        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }
        public override double getMonthSalary()
        {
            return monthlySalary;
        }
        public override string toString()
        {
            return "Employee's name: " + base.Name + "\nEmployee's salary: " + getMonthSalary();
        }
    }
}

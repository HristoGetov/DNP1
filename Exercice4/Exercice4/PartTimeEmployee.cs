using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class PartTimeEmployee:Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public PartTimeEmployee(String name, double hourlyWage, int hoursperMonth) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursperMonth;
            
        }
        public double getHourlyWage()
        {
            return hourlyWage;
        }
        public int getHoursPerMonth()
        {
            return hoursPerMonth;
        }
        public override double getMonthSalary()
        {
            return (hourlyWage * hoursPerMonth);
        }
        public override String toString()
        {
            return "Employee name: " + base.Name + "\nHourly wage: " + getHourlyWage() + "\nHours for month: " + getHoursPerMonth() + "\nMonthly salary: " + getMonthSalary();
        }
    }
}

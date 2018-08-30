using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
   
    class PartTimeEmployee:Employee
    {
        public double HourlyWage { get; set; }
        public int HoursPerMonth { get; set; }
        public PartTimeEmployee(String name, double hourlyWage, int hoursperMonth) : base(name)
        {
            HourlyWage = hourlyWage;
            HoursPerMonth = hoursperMonth;
        }
        public  override double getMonthSalary()
        {
            return HourlyWage + HoursPerMonth;
        }

       
    }
}

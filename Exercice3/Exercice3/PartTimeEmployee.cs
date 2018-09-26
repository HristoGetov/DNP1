using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
   
    public class PartTimeEmployee:Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;
       
        public PartTimeEmployee(String name, double hourlyWage, int hoursperMonth) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursperMonth;
        }
        public  override double getMonthSalary()
        {
            return (hourlyWage * hoursPerMonth);
        }

       
    }
}

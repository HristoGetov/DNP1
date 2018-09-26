using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class PartTimeStudent:Employee,IStudent
    {
        private double hourlyWage;
        private int hoursPerWeek;
        private int startYear;
        public PartTimeStudent(String name, int startYear, double hourlyWage, int hoursPerWeek) : base(name)
        {
            this.startYear = startYear;
            this.hourlyWage = hourlyWage;
            this.hoursPerWeek = hoursPerWeek;
        }
    public override double getMonthSalary()
    {
        return (hoursPerWeek * hourlyWage);
    }

    public void Register(int year)
    {
        startYear = year;
    }
    public int getStartYear()
    {
        return startYear;
    }
        public override String toString()
        {
            return "Name: " + base.Name +  "\nStart year: " + getStartYear() + "\nSalary per month: " + getMonthSalary();
        }
}
}

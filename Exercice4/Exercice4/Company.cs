using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Company
    {
        private List<Employee> employees = new List<Employee>();

        public Company()
        {
        }
        public double getMontlySalaryTotal()
        {
            double totalsalaries = 0.0;
            for (int i = 0; i < employees.Count; i++)
            {
                totalsalaries += employees[i].getMonthSalary();
            }
            return totalsalaries;
        }
        public void EmployeeNewEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void addPartTimeStudent(PartTimeStudent student)
        {
            employees.Add(student);
        }
       
    }
}

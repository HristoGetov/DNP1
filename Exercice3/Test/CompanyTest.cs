using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice3;

namespace Test
{
    class CompanyTest
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PartTimeEmployee("Bob", 25.5, 130);
            Employee emp2 = new FulTimeEmployee("Dan", 50000);
            Employee emp3 = new PartTimeEmployee("John", 20, 150);
            Employee emp4 = new PartTimeEmployee("Bob", 25.5, 100);

            Employee emp5 = new PartTimeEmployee("Ian", 100, 150);
            Employee emp6 = new PartTimeEmployee("Greg", 85.5, 200);
            Employee emp7 = new FulTimeEmployee("Tomas", 40000);
            Employee emp8 = new PartTimeEmployee("Don", 60, 180);

            Exercice3.Company comp1 = new Company();
            Exercice3.Company comp2 = new Company();

            comp1.EmployeeNewEmployee(emp1);
            comp1.EmployeeNewEmployee(emp2);
            comp1.EmployeeNewEmployee(emp3);
            comp1.EmployeeNewEmployee(emp4);

            comp2.EmployeeNewEmployee(emp5);
            comp2.EmployeeNewEmployee(emp6);
            comp2.EmployeeNewEmployee(emp7);
            comp2.EmployeeNewEmployee(emp8);

            Console.WriteLine("Employee: " + emp1.getMonthSalary());
            Console.WriteLine("Employee: " + emp2.getMonthSalary());
            Console.WriteLine("Employee: " + emp3.getMonthSalary());
            Console.WriteLine("Employee: " + emp4.getMonthSalary());
            Console.WriteLine("Employee: " + emp5.getMonthSalary());
            Console.WriteLine("Employee: " + emp6.getMonthSalary());
            Console.WriteLine("Employee: " + emp7.getMonthSalary());
            Console.WriteLine("Employee: " + emp8.getMonthSalary());
            Console.Write("Total salary to pay: " +comp1.getMontlySalaryTotal() + "kr.");
            Console.ReadKey();
        }
    }
}

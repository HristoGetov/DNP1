using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class TestCompany
    {
        static void Main(string[] args)

        {
            PartTimeStudent student = new PartTimeStudent("Sam", 2018, 100, 20);
            PartTimeStudent student2 = new PartTimeStudent("Georg", 2018, 125.5, 10);
            PartTimeStudent student3 = new PartTimeStudent("Victor", 2017, 130.5, 20);
            Employee empl1 = new PartTimeEmployee("Bob", 150, 30);
            Employee empl2 = new FullTimeEmployee("Dan", 25000);
            Employee empl3 = new FullTimeEmployee("Stan", 30000);

            Company comp = new Company();
            comp.addPartTimeStudent(student2);
            comp.addPartTimeStudent(student3);
            comp.EmployeeNewEmployee(empl1);
            comp.EmployeeNewEmployee(empl2);
            comp.EmployeeNewEmployee(empl3);

            Console.WriteLine("Total salaries: " + comp.getMontlySalaryTotal()+"\n");
            Console.WriteLine("Student: " + student.toString()+ "\n\n"+ "Student: " + student2.toString()+"\n\n"+ "Student: " + student3.toString()+
                "\n\n"+"Employee: " + empl1.toString()+"\n\n"+"Employee: " + empl2.toString()+"\n\n"+"Employee: " + empl3.toString());

            Console.ReadKey();

        }
    }
}

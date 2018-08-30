using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    abstract class Employee
    {
    
        public String Name
        {
            get; set;
        }
        public Employee(String name)
        {
            Name = name;
        }
        public abstract double getMonthSalary();
        
    }
}

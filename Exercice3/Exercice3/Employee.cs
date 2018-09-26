﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
   public abstract class Employee
    {

        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee(String name)
        {
            this.name = name;
        }
        public abstract double getMonthSalary();
        
    }
}

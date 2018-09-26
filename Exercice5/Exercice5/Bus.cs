using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
     class Bus : Vehicle, ITaxable

    {
        
        private int regNumber;
        private double maxVelocity;
        private decimal vvalue;


        public Bus(int regNumber, double maxVelocity, decimal vvalue)
        {
            this.regNumber = regNumber;
            this.maxVelocity = maxVelocity;
            this.vvalue = vvalue;
        }
        public override int RegNumber()
        {
            return regNumber;
        }
        public override double MaxVelocity()
        {
            return maxVelocity;
        }
        public override decimal Vvalue()
        {
            return vvalue;
            
        }
       

        public decimal taxValue()
        {
            return Value() * 0.25;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class House : FixedProperty, ITaxable
    {
        private double area;
        
        public House(decimal propertyValue, double area) : base(propertyValue)
        {
            
            this.area = area;            
        }
       
        public decimal taxValue()
       
        {
            throw new NotImplementedException();
        }

        public override decimal estimatedValue()
        {
            throw new NotImplementedException();
        }

        public override bool inCity()
        {
            throw new NotImplementedException();
        }

        public override string location()
        {
            throw new NotImplementedException();
        }

      
    }
}

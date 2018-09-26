using System;
using System.Collections.Generic;
using System.Text;


namespace Exercice5
{
   abstract class FixedProperty
    {
        private decimal propertyValue;

        public decimal PropertyValue
        {
            get{ return propertyValue; }

        }
        public FixedProperty(decimal propertyValue)
        {
            this.propertyValue = propertyValue;
        }
        public abstract String location();
        public abstract bool inCity();
        public abstract decimal estimatedValue();
    }
}

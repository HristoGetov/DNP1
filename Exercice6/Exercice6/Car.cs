using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Car: IComparable<Car>
    {
        double EngineSize { get; set; }
        double Weight { get; set; }
        int TopSpeed { get; set; }

        public Car(double engineSize, double weight,int topSpeed)
        {
            EngineSize = engineSize;
            Weight = weight;
            TopSpeed = topSpeed;
        }

        public override string ToString()
        {
            return "Engine size: " + EngineSize + ", weight: " + Weight + ", top speed: " + TopSpeed;
        }
       

        public int CompareTo(Car cars)
        {
            if (cars.EngineSize > EngineSize)
                return -1;
            else if (cars.EngineSize < EngineSize)
                return 1;
            else
                return 0;
        }
    }
}

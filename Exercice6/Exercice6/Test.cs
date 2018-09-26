using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car(2.0, 1800, 200));
            cars.Add(new Car(4.0, 1600, 280));
            cars.Add(new Car(1.0, 1000, 160));
            cars.Add(new Car(1.8, 1600, 280));
            cars.Add(new Car(1.6, 1000, 260));

            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }
            cars.Sort();
            Console.WriteLine("\n");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
           

        }
    }
}

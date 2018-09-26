using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMath
{
    class Test
    {
        static void Main(string[] args)
        {
            MathLab.Math calc = new MathLab.Math();
            int t1 = 10;
            int t2 = 10;
            double d1 = 5.5;
            double d2 = 2.5;
            Console.WriteLine("10+ 10 = " + calc.add(t1, t2));
            Console.WriteLine("10 - 10 = " + calc.sub(t1,t2));
            Console.WriteLine("10 * 10 = " + calc.multiplication(t1,t2));
            Console.WriteLine("5.5 * 2.5 = " + calc.multiDouble(d1,d2));
            Console.WriteLine("5.5 + 2.5 = " + calc.addDoubles(d1, d2));

            Console.ReadKey();
        }
    }
}

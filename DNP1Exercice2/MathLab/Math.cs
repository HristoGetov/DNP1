using System;

namespace MathLab
{
    public class Math
    {
        public int add(int t1, int t2){ return t1 + t2; }
        public int sub(int t1, int t2){ return t1 - t2; }
       public double addDoubles(double d1, double d2){ return d1 + d2; }
       public double subsDouble(int d1, int d2) { return d1-d2;  }
       public int multiplication(int t1, int t2) { return t1 * t2; }
        public int devision(int t1, int t2)
        {
            try
            {
                return t1 / t2;
            }
            catch (DivideByZeroException e)
            {

                throw;
            }
        }
        public double multiDouble(double t1, double t2) { return t1 * t2; }
        public double devisionDouble(double t1, double t2)
        {
            try
            {
                return t1 / t2;
            }
            catch (DivideByZeroException e)
            {

                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualNumber
{
    public class DualNumber
    {
        public double F { get; }
        public double FPrime { get; }

        public DualNumber(double constant)
        {
            F = constant;
            FPrime = 0;
        }

        public DualNumber(double f, double fprime)
        {
            F = f;
            FPrime = fprime;
        }

        public static DualNumber operator+(DualNumber a, DualNumber b)
        {
            return new DualNumber(a.F + b.F, a.FPrime + b.FPrime);
        }

        public static DualNumber operator-(DualNumber a, DualNumber b)
        {
            return new DualNumber(a.F - b.F, a.FPrime - b.FPrime);
        }

        public static DualNumber operator*(DualNumber a, DualNumber b)
        {
            return new DualNumber(a.F * b.F, a.F * b.FPrime + a.FPrime * b.F);
        }

        public static DualNumber operator/(DualNumber a, DualNumber b)
        {
            return new DualNumber
                (a.F / b.F, 
                (a.FPrime * b.F - a.F * b.FPrime) / (b.FPrime * b.FPrime));
        }
    }
}

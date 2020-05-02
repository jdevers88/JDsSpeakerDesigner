using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View
{
    public class Fraction
    {
        int numerator;
        int denominator;
        int coefficient;
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
            coefficient = 0;
        }
        public Fraction(int inputNumerator, int inputDenominator, int inputCoefficient)
        {
            numerator = inputNumerator;
            denominator = inputDenominator;
            coefficient = inputCoefficient;
            Reduce();
        }
        public void Reduce()
        {
            if (numerator >= denominator)
            {
                coefficient = numerator / denominator;
                numerator = numerator - (denominator * coefficient);
            }
            int multiple = numerator;
            while  (multiple > 1)
            {
               if (((denominator % multiple) == 0) & ((numerator % multiple) == 0))
               {
                   numerator = numerator / multiple;
                   denominator = denominator / multiple;
               }
            }
        }

        


    }
}

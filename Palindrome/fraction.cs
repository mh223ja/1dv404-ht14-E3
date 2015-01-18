using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
  class Fraction
	{
       public int getNumerator {get; private set;} //two methods that return numerator and denominator

       public int getDenominator {get; private set;}

       public Fraction(int numerator, int denominator)
       {
           getNumerator = numerator;
           getDenominator = denominator;
       }

        public Fraction Add(Fraction fraction)
       {
           int numeratorOne = this.getNumerator();
           int numeratorTwo = fraction.getNumerator();
           int denominatorOne = this.getDenominator();
           int denominatorTwo = fraction.getDenominator();

           int numeratorThree = (numeratorOne * denominatorTwo) + (numeratorTwo * denominatorOne);
           int denominatorThree = (denominatorOne * denominatorTwo);

           Fraction final = new Fraction(numeratorThree, denominatorThree);

           return final;
       }

        public Fraction Multiply (Fraction fraction)
        {
            int numeratorOne = this.getNumerator();
            int numeratorTwo = fraction.getNumerator();
            int denominatorOne = this.getDenominator();
            int denominatorTwo = fraction.getDenominator();

            int numeratorThree = numeratorOne * numeratorTwo;
            int denominatorThree = denominatorOne * denominatorTwo;

            Fraction final = new Fraction(numeratorThree, denominatorThree);

            return final;
        }

        public bool isNegative(Fraction fraction)
        {
            if (fraction.getNumerator<0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool isEqualTo(Fraction fractionOne, Fraction fractionTwo)
        {


            if (fractionOne.getNominator == fractionTwo.getNominator && fractionOne.getDenominator == fractionTwo.getDenominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return getNumerator + "/" + getDenominator;
        }
	}
}

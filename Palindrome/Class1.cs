using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
       public int getNumerator {get; set;} //two methods that return numerator and denominator

       public int getDenominator {get;set;}

       public Fraction(int numerator, int denominator)
       {
           getNumerator = numerator;
           getDenominator = denominator;
       }

        public Fraction add(Fraction fraction)
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

        

       
	}
}

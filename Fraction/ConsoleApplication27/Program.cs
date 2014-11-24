using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumerator;
            int inputDenominator;
            

             
            Console.WriteLine("Welcome to the Fraction Factory");
            Console.WriteLine("");
            Console.WriteLine("Input two fractions and the Fraction Factory will add them, multiply them and compare them");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Numerator of fraction one: ");
            inputNumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Denominator of fraction one: ");
            inputDenominator = int.Parse(Console.ReadLine());

            if (inputDenominator == 0)
            {
                throw new FormatException();
            }
         
            Fraction fractionOne = new Fraction(inputNumerator, inputDenominator);

           Console.WriteLine("Numerator of fraction two:  ");
            inputNumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Denominator of fraction two: ");
            inputDenominator = int.Parse(Console.ReadLine());

            if (inputDenominator == 0)
            {
                throw new FormatException();
            }

            Fraction fractionTwo = new Fraction(inputNumerator, inputDenominator);

            Fraction fractionThree = fractionOne.Add(fractionOne, fractionTwo);

            Console.WriteLine("Fraction One plus Fraction Two is: {0}", fractionThree.ToString());

          Fraction fractionFour = fractionOne.Multiply(fractionTwo);
           Console.WriteLine("Fraction One times Fraction Two is {0}", fractionFour.ToString());
          bool equal = fractionOne.isEqualTo(fractionOne, fractionTwo);            if (equal == true)            {                Console.WriteLine("The fractions are equal");

            }
            else{
                Console.WriteLine("The fractions are not equal");
            }

        }
    }
}

 

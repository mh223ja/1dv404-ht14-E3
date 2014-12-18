using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfZeros = 0;
            int numberOfEvens = 0;
            int numberOfOdds = 0;
            int inputNumber;

            Console.WriteLine("This program will tell you how many zeros, odd and even digits are in your number");
            Console.WriteLine("");
            Console.WriteLine("Enter your number here: ");
            inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber.ToString().Length; i++)
            {

                if (inputNumber.ToString()[i] == '0')
                {
                    numberOfZeros++;
                }


                else if (inputNumber.ToString()[i] % 2 == 0)
                {
                    numberOfEvens++;
                }

                if (inputNumber.ToString()[i] % 2 == 1)
                {
                    numberOfOdds++;
                }

            }


            Console.WriteLine(" The total number of even digits is {0} the total odd digits is {1} and the total number of zeros is {2} ", numberOfEvens, numberOfOdds, numberOfZeros);
        }
    }
}




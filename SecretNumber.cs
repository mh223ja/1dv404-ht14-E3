using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        //name variables necessary
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        //Initialize (public)
        public void Initialize()
        {
            _count = 0; //set count

            Random random = new Random(); //set random number
            _number = random.Next(1, 101); //set at 101 to make sure limit is 100
        }

        public bool MakeGuess(int number) //must be bool for MakeGuess with int
        {

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(); //catch numbers that are outside of range
            }

            else
            {
                if(_count < MaxNumberOfGuesses) //if number is under 7
                {
                    if (number == _number)
                    {
                        Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} gissningar", (1 + _count));
                        return true;
                    }

                    else
                    {
                        if (number < _number)  //messages - too low, and how many guesses left
                        {
                            Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (6 - _count));
                        }
                        //guesses should be 6 - count to account for 0

                        else if (number > _number)
                        {
                            Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (6 - _count));
                        }


                    }
                    _count++;
                    if (_count > 6)
                        Console.WriteLine("Ingen fler gissningar. Det hemliga talet var {0}.", _number);


                    return false;
                }


                {
                    throw new ApplicationException();
                }
            }
        }
        public SecretNumber()
        {
            Initialize();
        }
    }
}


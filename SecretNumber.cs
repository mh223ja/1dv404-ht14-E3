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
        private Random _random;
        public const int MaxNumberOfGuesses = 7;

       
          public int Initialize ()
          {
              _count = 0;

              _random=new Random ();
              _number=_random.Next (1, 101);
          }

        public int MakeGuess ()
        {
           
            int number;

            if (number < 1 || number >100)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (number < _number)
                { Console.WriteLine ("{0} är för lågt. Du har {0} gissningar kvar.", number, (6-_count));
            }
            
            else {
                    if (number > _number)
                    {
                        Console.WriteLine("{0} är för högt. Du har {0} gissningar kvar.", number, (6 - _count));
                    }
                    else
                    { if (number == _number)
                    {
                        Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} gissningar", (6 + _count));
                    }
                    }
                    if (_count=6)
                    {
                        Console.WriteLine("Ingen fler gissningar. Det hemliga talet var {0}.", _number);
                    }

            }
            }

       }
    }
}

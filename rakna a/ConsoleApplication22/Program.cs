using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput;
            int numberA= 0;
            int numbera= 0;

            Console.WriteLine("Find out how many [Aa]s there are in your sentence");
            Console.WriteLine("Input your sentence: ");

            textInput = Console.ReadLine();

            foreach  (char A in textInput)
            {
                if (A == 'A')
                {
                
                    numberA++;
                     }
                }

            foreach (char a in textInput)
            {
                if (a == 'a')
                {
                    numbera++;
                }
             }

            Console.WriteLine("You have {0} A:s in your text and {1} a:s in your text" numberA, numbera);

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = "";
            string reverseInputText = "";
            string inputTextEdited = "";

            Console.WriteLine("PALINDROME DETECTOR");
            Console.WriteLine("");
            Console.WriteLine("Enter your possible palindrome:");

            inputText = Console.ReadLine();
            inputTextEdited = inputText.Replace(" ", String.Empty);
            
            foreach (char c in inputTextEdited)
            {
                inputTextEdited = inputTextEdited.ToLower();
            }

            Console.WriteLine(inputTextEdited);

            for (int i = inputTextEdited.Length - 1; i >= 0; i--)
            {
                reverseInputText += inputTextEdited[i];
               
            }


            if (reverseInputText == inputTextEdited)
            {
                Console.WriteLine("{0} is a Palindrome!", inputText);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome!", inputText);
            }


        }
    }
}

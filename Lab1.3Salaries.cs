using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            do //call for ReadInt
            {
                int numberOfSalaries = ReadInt("Ange antal löner att mata in:");
                //push to process salaries if meets standard
                if (numberOfSalaries >= 2)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                { //error message if less than 2
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.ResetColor();
                } //Option to restart or exit

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck tangent för ny beräkning - ESC avslutar.");
                Console.ResetColor();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }




        static void ProcessSalaries(int numberOfSalaries) //set up new method to get array
        { //set up array
            int[] salaryArray = new int[numberOfSalaries];
            for (int i = 0; i < salaryArray.Length; i++)
            {
                salaryArray[i] = ReadInt(string.Format("Ange lön nummer {0}:", i + 1));
            }
            //clone array to get median
            int[] medianArray = (int[])salaryArray.Clone();
            Array.Sort(medianArray);

            //find medians if odd or even number 

            int medianA;
            int medianB;
            int medianC;

            if (numberOfSalaries % 2 == 0)
            {
                medianA = medianArray[medianArray.Length / 2];
                medianB = medianArray[medianArray.Length / 2 - 1];
                medianC = ((medianA + medianB) / 2);
            }
            else
            {
                medianC = medianArray[medianArray.Length / 2];
            }

            //Write out answers using currency
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("MedianLön:{0:c0}", medianC);
            Console.WriteLine("Medellön:{0:c0}", salaryArray.Average());
            Console.WriteLine("Lönespridning:{0:c0}", salaryArray.Max() - salaryArray.Min());
            Console.WriteLine("------------------------------------------------------------------------------------------");

            //list salaries in three columns (if three)

            for (int i = 0; i < salaryArray.Length; i++)
            {
                if ((i - 1) % 3 != 0)
                {
                  
                else
                {
                    
                }
            }
        }
        static int ReadInt(string prompt="");


  }
}
                       


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingChange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double totalCost;
            int cashPaid;
            uint amountOwed;
            double roundingOffAmount;
            int change;
            int notes;

            while (true)
            {
                try
                {// Input total
                    Console.Write("Ange totalsumma: ");
                    totalCost = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totalsumman måste vara en siffra.");
                    Console.ResetColor();

                }
            }
            //program should close if less than 1 krona
            if (totalCost < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Totalsumman är för liten. Köpet kan inte genomföras.");
                Console.ResetColor();
                return;

            }
            while (true)
            {
                try
                {// Input erhållet belopp
                    Console.Write("Ange erhållet belopp: ");
                    cashPaid = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erhållet belopp måste vara en siffra.");
                    Console.ResetColor();
                }
            }


            // round off öre
            amountOwed = (uint)Math.Round(totalCost);
            roundingOffAmount = totalCost - amountOwed;

            //program should close if cash paid is less than amountowed
            if (cashPaid < amountOwed)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Erhållet belopp felaktig.");
                Console.ResetColor();
                return;
            }
            //Calculate change
            change = cashPaid - (int)amountOwed;
            // Make receipt
            Console.WriteLine("");
            Console.WriteLine("Kvitto");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Totalt:          {0,8:c}", totalCost);
            Console.WriteLine("Öresavrundning:  {0,8:c}", roundingOffAmount);
            Console.WriteLine("Att Betala:      {0,8:c0}", amountOwed);
            Console.WriteLine("Kontant:         {0,8:c0}", cashPaid);
            Console.WriteLine("Tillbaka:        {0,8:c0}", change);
            Console.WriteLine("-------------------------------------");
            // How many of each note
            notes = change / 500;

            if (notes >= 0)
            {
                Console.WriteLine("Antal 500-lappar \t :{0}", notes);
                change = change % 500;
            }
            notes = change / 100;

            if (notes >= 0)
            {
                Console.WriteLine("Antal 100-lappar \t :{0}", notes);
                change = change % 100;
            }
            notes = change / 20;

            if (notes >= 0)
            {
                Console.WriteLine("Antal 20-lappar \t :{0}", notes);
                change = change % 20;
            }
            notes = change / 5;

            if (notes >= 0)
            {
                Console.WriteLine("Antal 5-kronor \t \t :{0}", notes);
                change = change % 5;
            }
            notes = change / 1;

            if (notes >= 0)
            {
                Console.WriteLine("Antal 1-kronor \t \t :{0}", notes);
            }







        }
    }
}



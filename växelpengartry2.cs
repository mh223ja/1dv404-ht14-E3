using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingChangeversion2
{
    class Program
    {
        static void Main(string[] args)
        {//declare variables
            double totalCost;
            int cashPaid;
            uint amountOwed;
            double roundingOffAmount;
            int change;
            int notes;

            while (true)
                 {
                try
                     {//input total
                    Console.Write("Ange totalsumma: ");
                    totalCost = double.Parse(Console.ReadLine());
                    
             
         //error message if wrong
                    }
                catch
                     {Console.BackgroundColor = ConsoleColor.Red;
                     Console.WriteLine("FEL! Försök igen");
                    Console.ResetColor();
                     }

                      if (totalCost < 1) //if this doesn't work maybe switch order?)
                        {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine ("Totalsumman är för liten. Köpet kan inte genomföras.");
                        Console.ResetColor();
                        return;
                          
                        }
                 
                  }
                      
                         
              
               while (true)
                   {
                   try 
         // input total paid
                       {
                         Console.Write("Ange erhållet belopp: ");
                    cashPaid = int.Parse(Console.ReadLine());
                    
                     }
                   catch
                     {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine ("FEL! Erhållet belopp felaktig.");
                    Console.ResetColor();
                     }
                 }
//round öre

            amountOwed = (uint)Math.Round(totalCost);
            roundingOffAmount = totalCost - amountOwed;
       
            if (amountOwed < cashPaid)
                {
                 Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine ("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                    Console.ResetColor();
                return;
                 }

              //Calculate change
            change = cashPaid - (int)amountOwed;

            // Make receipt
            Console.WriteLine("Kvitto");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Totalt:  {0,8:c}", totalCost);
            Console.WriteLine("Öresavrundning:  {0,8:c}", roundingOffAmount);
            Console.WriteLine("Att Betala:  {0,8:c0}", amountOwed);
            Console.WriteLine("Kontant:  {0,8:c0}", cashPaid);
            Console.WriteLine("Tillbaka:  {0,8:c0}", change);

            Console.WriteLine("-------------------------------------");

           
           // How many of each note
            notes = change / 500;

            if (notes > 0)
           
               { Console.WriteLine("Antal 500-lappar \t :{0}", notes);
                change = change % 500;
                    }

             notes = change / 100;
             if (notes > 0)
             {
                 Console.WriteLine("Antal 100-lappar \t :{0}", notes);
                 change = change % 100;
             }
             notes = change / 20;
             if (notes > 0)
             {
                 Console.WriteLine("Antal 20-lappar \t  :{0}", notes);
                 change = change % 20;
             }
             notes = change / 5;
             if (notes > 0)
             {
                 Console.WriteLine("Antal 5-kronor \t \t :{0}", notes);
                 change = change % 5;
             }
             notes = change / 1;
             if (notes > 0)
             {
                 Console.WriteLine("Antal 1-kronor \t \t :{0}", notes);
                }





        

        }
    }
}

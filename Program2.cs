using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main (string[] args)
        {
            // test one: standard constructor
            AlarmClock testOne = new AlarmClock();
            Console.WriteLine("Test 1.");
            Console.WriteLine("Test of standard constructor");
            Console.WriteLine(testOne.ToString());
            Console.WriteLine();

            //test two two parameters
            AlarmClock testTwo = new AlarmClock(9, 42);
            Console.WriteLine("Test 2.");
            Console.WriteLine("Test of constructor with two parameters.");
            Console.WriteLine(testTwo.ToString ());
            Console.WriteLine();

            //test three four parameters
            AlarmClock testThree = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("Test 3.");
            Console.WriteLine("Test of constructor with four parameters <13,24,7,35>");
            Console.WriteLine(testThree);

            //test four test TickTock for 13 minutes
            AlarmClock testFour = new AlarmClock(23, 58, 7, 35);
            Console.WriteLine("Test 4.");
            Console.WriteLine("Set AlarmClock to 23:58 and let run for 13 minutes");
            Run(testFour,13);
            

            //test five to see if the alarm works
            AlarmClock testFive = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("Test 5.");
            Console.WriteLine("Set AlarmClock to 6:12 and set AlarmClock for 6:15. Let run 6 miutes.");
            Run(testFive, 6);

            //test6 check property error messages -try catch?
            AlarmClock testSix = new AlarmClock();
            Console.WriteLine("Test 6.");
            Console.WriteLine("Test properties to see if exception is thrown if the time or alarm has the wrong value");
            try
            {
                testSix.Hour = 24;
            }
            catch 
            {
                ViewErrorMessage("The hour is not within the intervall 0-23");
            }
            try
            {
                testSix.Minute = 61;
            }
            catch
            {
                ViewErrorMessage("The minute  is not within the intervall 0-59");
            }
            try
            {
                testSix.AlarmHour = 24;
            }
            catch
            {
                ViewErrorMessage("Alarm Hour is not within the intervall 0-23")
            }
            try
            {
            }
          //test 7 check method error messages (need to add to AlarmClock**)
            
        }
       private static void Run(AlarmClock ac, int minutes)
       {
        for (int i =0;i<minutes; i++)
           
    {
        if (ac.TickTock())
        {
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine(ac.ToString () + "BEEP!BEEP!BEEP!BEEP!");
            Console.ResetColor();
              }
            Console.WriteLine (ac.ToString());

        }
    }


        private static void ViewErrorMessage (string message)
       {
           Console.BackgroundColor = ConsoleColor.Red;
           Console.WriteLine(message);
           Console.ResetColor();
       }
            



        }
    }




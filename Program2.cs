using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            // test one: standard constructor
            AlarmClock testOne = new AlarmClock();
            ViewTestHeader("Test 1. \n Test of standard constructor\n");
            Console.WriteLine(testOne);
            

            //test two two parameters
            AlarmClock testTwo = new AlarmClock(9, 42);
            ViewTestHeader("Test 2. \n Test of constructor with two parameters \n ");
            Console.WriteLine(testTwo);

            //test three four parameters
            AlarmClock testThree = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3. \n Test of constructor with four parameters <13,24, 7,35> \n");
            Console.WriteLine(testThree);
            

            //test four test TickTock for 13 minutes
            AlarmClock testFour = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("Test 4. \n Set AlarmClock to 23:58 and let run for 13 minutes \n");
            Run(testFour, 13);
           


            //test five to see if the alarm works
            AlarmClock testFive = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5. \n Set AlarmClock to 6:12 and set Alarm for 6:15. Let run 6 minutes \n ");
            Run(testFive, 6);
            
            //test6 check property error messages -try catch?
            AlarmClock testSix = new AlarmClock();
            ViewTestHeader("Test 6. \n Test properties to see if exception is thrown if the time or alarm has the wrong value \n");
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
                testSix.Minute = 60;
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
                ViewErrorMessage("Alarm Hour is not within the intervall 0-23");
            }
            try
            {
                testSix.AlarmMinute = 60;
            }
            catch
            {
                ViewErrorMessage("Alarm minute is not within the interval 0-59");
            }
            //test 7 check method error messages (need to add to AlarmClock**)
            ViewTestHeader("Test 7. \n Test construct for exceptions if time or alarm are outside of interval \n ");
            try {
                testSix = new AlarmClock(24, 0);
            }
            catch {
                ViewErrorMessage("Hour is not within the interval 0-23");
            }
            try { }
            catch { }
            try { }
            catch { }
            try { }
            catch { }
        }
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ac.ToString() + "BEEP!BEEP!BEEP!BEEP!");
                    Console.ResetColor();
                }
                Console.WriteLine(ac.ToString());

            }
        }


        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void ViewTestHeader(string header)
        {
            string horizontal = "\n ----------------------------------------------------";
            Console.WriteLine();
            Console.WriteLine(horizontal);
            Console.WriteLine(header);
        }



    }
}




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
            Console.WriteLine(testThree.ToString());

            //test four test TickTock for 13 minutes
            AlarmClock testFour = new AlarmClock(23, 58, 7, 35);
            Console.WriteLine("Test 4.");
            Console.WriteLine("Set AlarmClock to 23:58 and let run for 13 minutes");
            TickTock(testFour, 13);

            AlarmClock testFive = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("Test 5.");
            Console.WriteLine("Set AlarmClock to 6:12 and set AlarmClock for 6:15. Let run 6 miutes.");
            TickTock(testFive, 6);

            AlarmClock testSix = new AlarmClock();
            



        }
    }
}

namespace ConsoleApplication16
{
    public class Program
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
  

    class Program
    {
        private static int ViewMenu()
        {
           
                Console.Clear ();
                Console.BackgroundColor=ConsoleColor.DarkCyan;
                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine (" ╔═══════════════════════════════════╗ ");
                Console.WriteLine (" ║          Geometric Shapes         ║ ");
                Console.WriteLine (" ╚═══════════════════════════════════╝ ");
                Console.BackgroundColor=ConsoleColor.Black;
                Console.WriteLine ("\n 0. Quit");
                Console.WriteLine ("\n 1. Ellipse");
                Console.WriteLine ("\n 2. Rectangle");
                Console.WriteLine("\n ═══════════════════════════════════════════\n");
                Console.WriteLine("\n Select Choice [0-2]");
                Console.ResetColor ();

                if (int.TryParse (Console.ReadLine(), out index) && index >=0 && index <=3);
                {
                    return index;
                }

               
                {
                    Console.BackgroundColor=ConsoleColor.Red;
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.WriteLine ("WRONG! Choose a number between 0-3");
                    Console.BackgroundColor=ConsoleColor.DarkBlue;
                    Console.WriteLine("\n to continue");
                    Console.ResetColor();
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.CursorVisible=true;

                }
                while ();
            }
        

        private static void ViewDetail(shape)
        { }

        private static ReadDoubleGreaterThanZero ()
        {}
        CreateShape ()
        {}

    }
}
    
}

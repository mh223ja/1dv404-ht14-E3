using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish rows
            for (int row = 0; row < 25; row++)
            //designate colors
            {
                switch (row % 3)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                //space before row
                if ((row % 2) == 0)
                { Console.Write(" "); }

                for (int column = 0; column < 39; column++)
                { Console.Write("* "); }
                Console.ResetColor();
                Console.WriteLine();
            }
            //write asterix
        }
    }
}

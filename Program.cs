using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab 2.1
{
    class Program
    {
        static void Main(string[] args)
        {
           //establish loop
            for (int row = 0; row < 25; row++)
          //different colors for rows
{ 
            switch  (row %3)
            { 

            case"0" :
                Console.BackgroundColor=ConsoleColor.Yellow;
                break;
            case "1": 
                Console.BackgroundColor=ConsoleColor.Magenta;
                break;
            case "2":
                Console.BackgroundColor=ConsoleColor.Green;
                break;
                     }
                //space every other line
            if ((row  % 2)=0)
               
               { Console.Write(""); }
                for (int column = 1; column<39; column++)
                    { Console.Write("*"); }
                 }
        }
    }
}

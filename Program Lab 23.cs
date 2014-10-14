using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
  

    class Program
    {
        static void Main (string [] args)
             {
            string chosenShape;
       
           
            do 
            {
                ViewMenu();
                chosenShape=Console.ReadLine();

            
            switch (chosenShape)
            {
                case "0":
                    return;

                case "1":
                    ViewShapeDetail(CreateShape(ShapeType.ellipse);
                    break;

                case "2":
                    ViewShapeDetail(CreateShape(ShapeType.rectangle);
                    break;
            }
            Console.ReadLine();
                 }
            while (true);
            }
           
     

            
        private static void ViewMenu()
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
            }
           
        

        private static void ViewShapeDetail(shape shape)
        { 
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.ForegroundColor=ConsoleColor.White;
             Console.WriteLine("\n ═══════════════════════════════════════════\n");
             Console.WriteLine (" ║           Details                         ║ ");
             Console.WriteLine("\n ═══════════════════════════════════════════\n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine ("\n ═══════════════════════════════════════════\n");


        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            

          while (true)
          Console.Write (prompt);
          string selection = Console.ReadLine();
            
            try
            {
                double input = double.Parse(selection);
                if (input <=0)
                {
                    throw new OverflowException();
                }
                return input;
            }
            catch (FormatException)
            {
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("WRONG! {0} can not be interpreted as a value!", selection);
                Console.ResetColor();
            }
            catch (OverflowException)
                {
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("WRONG! You need to give a number larger than 0");
                Console.ResetColor();
                 }
             }


   
  

        private static shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("\n ═══════════════════════════════════════════\n");

            switch (shapeType)
            {
                case ShapeType.ellipse:
                    Console.BackgroundColor=ConsoleColor.Green;
                    Console.ForegroundColor=White;
                    Console.WriteLine("\n ═══════════════════════════════════════════\n");
                    Console.WriteLine (" ║           Ellipse                         ║ ");
                    Console.WriteLine("\n ═══════════════════════════════════════════\n");
                    break;
                case ShapeType.rectangle:
                    Console.BackgroundColor=ConsoleColor.Green;
                    Console.ForegroundColor=White;
                    Console.WriteLine("\n ═══════════════════════════════════════════\n");
                    Console.WriteLine (" ║           Ellipse                         ║ ");
                    Console.WriteLine("\n ═══════════════════════════════════════════\n");
                  break;
                    
                    double length=ReadDoubleGreaterThanZero("Give length:");
                    double width=ReadDoubleGreaterThanZero("Give width:");

                    if (shapeType=shapeType.Ellipse)
                    {
                        Ellipse shapeEllipse = new Ellipse (length,width);
                        return shapeEllipse;
                    }
                    if (shapeType=shapeType.Rectangle)
                    {
                        Rectangle shapeRectangle = new Rectangle (length,width);
                        return shapeRectangle;
                    }
                     }
            }
        }

    }

    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Program
    {//Main Method should call View Menu and then CreateShape if 0 is not chosen
        static void Main(string[] args)
        {
            string chosenShape;

            do
            { //do while - call menu
                ViewMenu();
                chosenShape = Console.ReadLine();
                //try to parse input? and catch non-numbers?
                try
                {
                    int choice = int.Parse(chosenShape); //create int & catch exceptions

                    if (choice < 0 || choice > 2)
                    {
                        throw new OverflowException();
                    }
                    switch (choice)
                    {   //list choices to filter into into selected shapes and create shapes???
                        case 0:
                            return;
                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;
                    }

                }

                catch (OverflowException) //setup error message
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("WRONG! Give a number between 0 and 2");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("WRONG! Give a number between 0 and 2");
                    Console.ResetColor();
                }

                //message to push any key to continue that should come up no matter what the selection
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Push any key to continue or ESC to exit");
                Console.ResetColor();
            }//set up so above message works
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }


        private static void ViewMenu()
        {  //show menu with given choices
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║          Geometric Shapes         ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n 0. Quit");
            Console.WriteLine("\n 1. Ellipse");
            Console.WriteLine("\n 2. Rectangle");
            Console.WriteLine("\n ═══════════════════════════════════════════\n");
            Console.WriteLine("\n Select Choice [0-2]");
            Console.ResetColor();
        }
        //private static (void?)
        private static void ViewShapeDetail(Shape shape) //write out details of shape from calculations
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  ══════════════════════════════════════════  ");
            Console.WriteLine(" ║           Details                        ║ ");
            Console.WriteLine("  ══════════════════════════════════════════  ");
            Console.ResetColor();
            Console.WriteLine(shape.ToString()); //call tostring to give out info
            Console.WriteLine("\n ═══════════════════════════════════════════\n");
        }
        //private static method that should call prompt and give error message
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string selection = Console.ReadLine();
                try
                {//parse the statement and then reject anything that is not greater than 0
                    double input = double.Parse(selection);
                    if (input <= 0)
                    {
                        throw new OverflowException();
                    }
                    return input;
                }

                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("WRONG! You need to give a number larger than 0");
                    Console.ResetColor();
                }
            }
        }
        //method Createshape should read figures length and width
        //Contain parameter ShapeType that indicates if a rectangle or triangle will be built
        private static Shape CreateShape(ShapeType ShapeType)
        {
            
            switch (ShapeType)
            {
                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("  ══════════════════════════════════════════  ");
                    Console.WriteLine(" ║           Ellipse                        ║ ");
                    Console.WriteLine("  ══════════════════════════════════════════  ");
                    Console.ResetColor();
                    break;

                case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("  ═══════════════════════════════════════════   ");
                    Console.WriteLine(" ║           Rectangle                        ║ ");
                    Console.WriteLine("  ═══════════════════════════════════════════   ");
                    Console.ResetColor();
                    break;
            }
                    double length = ReadDoubleGreaterThanZero("Input length:");
                    double width = ReadDoubleGreaterThanZero("Input width:");

                    if (ShapeType == ShapeType.Ellipse)
                    {
                        Ellipse shapeEllipse = new Ellipse(length, width);
                        return shapeEllipse;
                    }
                    if (ShapeType==ShapeType.Rectangle)
                    {
                        Rectangle shapeRectangle = new Rectangle(length, width);
                        return shapeRectangle;
                    }
                    else
                    {
                        throw new OverflowException();
                    }
            
        }
    }

}




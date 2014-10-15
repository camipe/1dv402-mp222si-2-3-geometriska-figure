using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            bool exit = false;

            do
            {
                ViewMenu();
                if (int.TryParse(Console.ReadLine(), out menuChoice) && menuChoice <= 2)
                {
                    switch (menuChoice)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;

                        default:
                            throw new ArgumentException("Problem med menyval. Försök igen.");
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 2.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\n   Tryck tangent för att fortsätta   ");
                    Console.ResetColor();
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.CursorVisible = true;
                }
                    

            
                
            } while (!exit);


        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Ellipse ellipse = new Ellipse(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden: "));
                    return ellipse;

                case ShapeType.Rectangle:
                    Rectangle rectangle = new Rectangle(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden: "));
                    return rectangle;

                default:
                    throw new NotImplementedException("Ingen giltig Shapetyp");
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double number;

            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out number) && number > 0 )
                {
                    return number;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n FEL! Ange ett positivt flyttal!\n");
                Console.ResetColor();                
            } while (true);
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------");
            Console.WriteLine("-                       -");
            Console.WriteLine("-  Geometriska figurer  -");
            Console.WriteLine("-                       -");
            Console.WriteLine("-------------------------");
            Console.ResetColor();   
            Console.WriteLine();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine();
            Console.WriteLine("1. Ellips.");
            Console.WriteLine();
            Console.WriteLine("2. Rektangel");
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.Write("Ange menyval [0-2]: ");

        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------");
            Console.WriteLine("-       Detaljer        -");
            Console.WriteLine("-------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("=========================");


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n   Tryck tangent för att fortsätta   ");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}

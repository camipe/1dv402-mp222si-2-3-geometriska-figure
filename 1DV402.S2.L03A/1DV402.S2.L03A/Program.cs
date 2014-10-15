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
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Ellipse ellipse = new Ellipse(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden"));
                    return ellipse;

                case ShapeType.Rectangle:
                    Rectangle rectangle = new Rectangle(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden"));
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
            } while (true);
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------");
            Console.WriteLine("-  Geometriska figurer  -");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine();
            Console.WriteLine("1. Ellips.");
            Console.WriteLine();
            Console.WriteLine("2. Rektangel");
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Ange menyval [0-2]: ");

        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-       Detaljer        -");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine(shape.ToString(shape));
            Console.WriteLine();
            Console.WriteLine("=========================");

        }
    }
}

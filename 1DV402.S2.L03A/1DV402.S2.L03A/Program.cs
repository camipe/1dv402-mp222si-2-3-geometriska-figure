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
            throw new NotImplementedException();
        }

        private static void ViewShapeDetail(Shape shape)
        {

        }
    }
}

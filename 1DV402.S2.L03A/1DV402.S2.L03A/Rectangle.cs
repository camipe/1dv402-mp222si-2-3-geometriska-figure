using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Rectangle : Shape
    {
        // Returning rectangle area
        public override double Area
        {
            get { return Length * Width; }
        }
        // Returning rectangle perimeter
        public override double Perimeter
        {
            get { return (2 * Width) + (2 * Length); }
        }

        // Constructor
        public Rectangle(double length, double width)
            :base(length, width)
        {

        }
    }
}

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
            get { return Length * Height; }
        }
        // Returning rectangle perimeter
        public override double Perimeter
        {
            get { return (2 * Height) + (2 * Length); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Shape
    {
        // Declaring fields
        private double _length;
        private double _height;

        // Properties
        public abstract double Area
        {
            get;
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talet får inte vara negativt");
                }
                else { _length = value; }
            }
        }

        public abstract double Perimeter
        {
            get;
        }

        public abstract double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talet får inte vara negativt");
                }
            }
        }
    }
}

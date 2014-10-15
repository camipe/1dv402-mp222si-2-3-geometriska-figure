﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    abstract class Shape
    {
        // Declaring fields
        private double _length;
        private double _width;

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

        public abstract double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talet får inte vara negativt");
                }
            }
        }

        // Constructor
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}

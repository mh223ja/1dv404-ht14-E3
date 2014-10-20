﻿using System;

namespace GeometricShapes
{
    class Rectangle : Shape
    {    //override baseclass
        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }


        public override double Perimeter
        {
            get
            {
                return (2 * Length) + (2 * Width);
            }
        }
        public Rectangle (double length, double width)
            : base(length, width)
        { }
    }
}


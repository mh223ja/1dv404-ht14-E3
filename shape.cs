using System;


namespace GeometricShapes
{//create enum with two shapetypes
    enum ShapeType
    {
        Ellipse, Rectangle
    }
    //abstract class shape
    public abstract class Shape
    {    //create fields
        private double _length;
        private double _width;

        //get set properties AreaPerimeterLength&width
        public abstract double Area
        {
            get;
        }
        public abstract double Perimeter
        {
            get;
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;

            }
        }
        //virtual method that can be overridden 

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }

        }

        //protected constructor

        protected Shape(double length, double width)
        {
            Width = width;
            Length = length;
        }

        public override string ToString()
        {
            return string.Format("Length:{0,10:} \n Width:{1,10:} \n Perimeter:{2,10:f1} \n Area:{3, 10:f1}", Length, Width, Perimeter, Area);
        }
    }
}



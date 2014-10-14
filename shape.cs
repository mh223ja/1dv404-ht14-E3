using System;


namespace Geometricshapes
{
    enum ShapeType
    {
        ellipse, rectangle
    }
        
       public abstract class shape
        {    //create fields
           private double _length;
           private double _width;

            //get set properties
           public abstract double Area {
                get;
            }
           public abstract double Perimeter
           {
               get;
           }

           public abstract double Length {
                get
            {
                return _length;
            }
                set {
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
            
            set {
            _width = value;
            }

                }
            //create methods

            protected shape (double length, double width);
               


            public string ToString (); 


          
                              
                         

        }

   }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricshapes
{
        
       public abstract class shape
        {    //create fields
           public  double _length;
           public double _width;

            //get set properties
           public double Area {
                get;
            }
           public double Length {
                get
            {
                return _length;
            }
                set {
                    _length = value;

                }
            }
            public double Perimeter 
            {
                get;
            }
        
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

            protected void shape (double length, double width);
           
        {
            _length=length;
            _width = width;

 }
            ToString (); String


          
                              
                         

        }
            
        }
    }


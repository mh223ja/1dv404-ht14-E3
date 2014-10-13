using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricshapes
{
        
       public abstract class shape
        {    //create fields
           private double _length;
           private double _width;

            //get set properties
           public abstract double Area {
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
           public abstract double Perimeter 
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

            protected shape (double length, double width);
               


            public string ToString (); 


          
                              
                         

        }

   }
    


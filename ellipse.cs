using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricshapes
{

public class Ellipse : shape
{
    //Area & Perimeter = Properties

    double area
    {
        get
        {
            return Math.PI*(Length/2)*(Width/2);
        }
    }

    double perimeter
    {
        get
        {
            return Math.pi * Math.Sqrt;
        }
    }

    //method - ellipse calculation
    public void ellipse(double length, double width)
    {

    }

}
}
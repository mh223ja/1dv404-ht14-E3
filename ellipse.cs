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

    public override double Area
    {
        get
        {
            return Math.PI*(Length/2)*(Width/2);
        }
    }

    public override double Perimeter
    {
        get
        {
            return Math.PI * Math.Sqrt;
        }
    }

    //method - ellipse calculation
    public void ellipse(double Length, double Width)
    {

    }

}
}
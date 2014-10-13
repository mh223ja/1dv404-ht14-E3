using System;

namespace Geometricshapes
{
public abstract class rectangle : shape

{    //override baseclass
	public override double Area
    {
        get
        {
    return length * width;
}
        }

	
    public override double perimeter
{
    get
{
   return  (2*length)+(2*width);
}
}
    public rectangle (double length, double width)
    {}
	}
}


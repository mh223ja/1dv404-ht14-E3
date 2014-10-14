using System;

namespace Geometricshapes
{
public abstract class rectangle : shape

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
   return  (2*Length)+(2*Width);
}
}
    public rectangle (double length, double width): base(length,width)
    {}
	}
}


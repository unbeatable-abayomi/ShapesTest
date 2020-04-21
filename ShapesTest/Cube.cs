using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Cube:Figure
    {
        public Cube (double inX, double inY) : base(inX, inY)
        {

        }


        public override double Area()
        {
            return 6*(Big_X * Big_X);
        }
    }
}

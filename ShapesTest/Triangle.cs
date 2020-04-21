using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Triangle:Figure
    {
        public Triangle(double inX, double inY) : base(inX, inY)
        {

        }


        public override double Area()
        {
            return (0.5 * Big_X*Big_Y);
        }
    }
}

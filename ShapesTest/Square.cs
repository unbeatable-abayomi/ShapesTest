using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Square:Figure
    {
        public Square (double inX, double inY) : base(inX, inY)
        {

        }


        public override double Area()
        {
            return (Big_X*Big_X);
        }
    }
}

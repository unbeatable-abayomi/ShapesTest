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


        public override double Area(double num1,double num2)
        {
            return 6 * (num1 * num1);
        }
    }
}

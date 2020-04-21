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


        public override double Area(double num1,double num2)
        {
            return (0.5 * num2*num2);
        }
    }
}

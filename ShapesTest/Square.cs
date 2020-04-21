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


        public override double Area(double num1,double num2)
        {
            return (num1 * num1);
        }
    }
}

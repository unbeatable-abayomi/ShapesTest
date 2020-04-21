using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Rectangle:Figure
    {

        public Rectangle(double inX, double inY) :base(inX,inY)
        {

        }



        public override double Area(double numOne, double two)
        {
            return (numOne * numOne);
        }
    }


}

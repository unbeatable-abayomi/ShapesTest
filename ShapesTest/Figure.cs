using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesTest
{
    class Figure
    {
        private double x;
        private double y;

        public Figure(double inX, double inY)
        {
            Big_X = inX;
            Big_Y = inY;
        }


        public double Big_X
        {
            get { return x; }
            set
            {
                if(value > 0.0)
                {
                    x = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }
        public double Big_Y
        {
            get { return y; }
            set
            {
                if (value > 0.0)
                {
                    y = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }

        }

        public virtual double Area(double num1 ,double num2)
        {
            return Big_X * Big_Y;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        //Fields
        private double length { get; set; }
        private double width { get; set; }

        //Constructors
        public Rectangle(double setLength, double setWidth)
        {
            SetLength(setLength);
            SetWidth(setWidth);
        }

        //Methods
        public double GetArea()
        {
            double area = length * width;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = (2 * length) + (2 * width);
            return perimeter;
        }

        public double GetLength()
        {
            return length;
        }
        public double GetWidth()
        {
            return width;
        }

        public void SetLength(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            length = setValue;
        }
        public void SetWidth(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            width = setValue;
        }

    }
}
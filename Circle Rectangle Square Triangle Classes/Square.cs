using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Rectangle_Square_Triangle_Classes
{
    class Square
    {
        //Fields
        private double side { get; set; }

        //Constructors
        public Square (double setSide)
        {
            SetSide(setSide);
        }

        //Methods
        public double GetArea()
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 4 * side;
            return perimeter;
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            side = setValue;
        }
    }
}

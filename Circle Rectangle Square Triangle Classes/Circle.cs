using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Rectangle_Square_Triangle_Classes
{
    class Circle
    {
        //Fields
        private double radius { get; set; }

        //Constructors
        public Circle(double setRadius)
        {
            SetRadius(setRadius);
        }

        //Methods
        public double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            radius = setValue;
        }
    }
}


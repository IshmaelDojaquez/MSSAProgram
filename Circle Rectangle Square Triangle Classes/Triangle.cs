using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Rectangle_Square_Triangle_Classes
{
    class Triangle
    {
        //Fields
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }

        //Constructors
        public Triangle (double setSideA, double setSideB, double setSideC)
        {
            SetSideA(setSideA);
            SetSideB(setSideB);
            SetSideC(setSideC);
        }

        //Methods
        public double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }

        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double GetSideC()
        {
            return sideC;
        }

        public void SetSideA(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            sideA = setValue;
        }
        public void SetSideB(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            sideB = setValue;
        }

        public void SetSideC(double setValue)
        {
            if (setValue <= 0)
            {
                setValue = 5;
            }
            sideC = setValue;
        }
    }
}

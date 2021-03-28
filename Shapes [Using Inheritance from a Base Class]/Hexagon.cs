using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Hexagon : Shape
    {
        //   F i e l d s

        private double side = 1.0;

        //   C o n s t r u c t o r s

        public Hexagon(double side)
        {
            SetSide(side);
        } // end Triangle( )

        //   M e t h o d s

        public override double GetArea()   // Heron's Formula
        {
            return 3 * Math.Sqrt(3) * side * side / 2;
        } // end GetArea( )

        public override double GetPerimeter()
        {
            return side * 6;
        } // end GetPerimeter( )   
        public double GetSide()
        {
            return side;
        } // end GetSide( )

        public void SetSide(double side)
        {
            if (side > 0)
            {
                this.side = side;
            }
        } // end SetSide( )
    }
}

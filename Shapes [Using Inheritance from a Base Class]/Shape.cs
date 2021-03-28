using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Shape
    {
        //FieldS
        private string color;

        //ConsTRuctOrs


        //Methods for Base class so Other cLasses can Implement
        public string GetColor()
        {
            return color;
        }

        public string SetColor(string color)
        {
            color = this.color;
            return color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

    }
}

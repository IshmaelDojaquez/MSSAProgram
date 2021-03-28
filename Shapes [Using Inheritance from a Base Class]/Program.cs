using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Hexagon(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
        }
    }
}

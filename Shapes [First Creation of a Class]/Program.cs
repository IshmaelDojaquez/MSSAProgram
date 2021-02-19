using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Initial new shape
            Rectangle rectangle1 = new Rectangle(-42, 5);
            Console.WriteLine($"The created rectangle has length of {rectangle1.GetLength()} and width of {rectangle1.GetWidth()}");

            //Setting new length and width
            rectangle1.SetLength(7);
            rectangle1.SetWidth(-98);

            //Checking new length and width has been implemented
            Console.WriteLine($"The new length is now {rectangle1.GetLength()} and width is now {rectangle1.GetWidth()}");

            //Calculating area and perimeter with new length and width
            Console.WriteLine($"The area of the rectangle is now {rectangle1.GetArea()} and the perimeter is now {rectangle1.GetPerimeter()}.");
        }
    }
}

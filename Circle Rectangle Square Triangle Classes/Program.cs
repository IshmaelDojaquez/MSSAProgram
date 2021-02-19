using System;

namespace Circle_Rectangle_Square_Triangle_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial new circle
            Circle circle1 = new Circle(5);
            Console.WriteLine($"The created circle has radius of {circle1.GetRadius()}");

            //Setting new radius
            circle1.SetRadius(-7);

            //Checking new radius has been implemented
            Console.WriteLine($"The new radius is now {circle1.GetRadius()}");

            //Calculating area and circumference with new radius
            Console.WriteLine($"The area of the circle is now {circle1.GetArea()} and the circumference is now {circle1.GetCircumference()}.");

            



            //Initial new square
            Square square1 = new Square(-5);
            Console.WriteLine($"\nThe created square has side of {square1.GetSide()}");

            //Setting new radius
            square1.SetSide(7);

            //Checking new radius has been implemented
            Console.WriteLine($"The new side is now {square1.GetSide()}");

            //Calculating area and circumference with new radius
            Console.WriteLine($"The area of the square is now {square1.GetArea()} and the perimeter is now {square1.GetPerimeter()}.");




            //Initial new triangle
            Triangle triangle1 = new Triangle(5, 5, 5);
            Console.WriteLine($"\nThe created triangle has sides of {triangle1.GetSideA()}, {triangle1.GetSideB()}, and {triangle1.GetSideC()}");

            //Setting new radius
            triangle1.SetSideA(-47);
            triangle1.SetSideB(7);
            triangle1.SetSideC(-97);

            //Checking new radius has been implemented
            Console.WriteLine($"The new sides are {triangle1.GetSideA()}, {triangle1.GetSideB()}, and {triangle1.GetSideC()}");

            //Calculating area and circumference with new radius
            Console.WriteLine($"The area of the triangle is now {triangle1.GetArea()} and the perimeter is now {triangle1.GetPerimeter()}.");

        }
    }
}

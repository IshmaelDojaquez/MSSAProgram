using System;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            double circleRadius = double.Parse(Console.ReadLine());
            double circumference = 2 * Math.PI * circleRadius;
            Console.WriteLine($"The circumference is {circumference}");

            double areaCircle = Math.PI * (circleRadius * circleRadius);
            Console.WriteLine($"The area is {areaCircle}");


            // Part 2
            Console.WriteLine("Part 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            double hemiRadius = double.Parse(Console.ReadLine());
            double volume = 4 / 3 * Math.PI * Math.Pow(hemiRadius, 3) / 2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("Part 3, area of a triangle (Heron's formula).");
            Console.Write("Enter the integer for side 'a' of the triangle: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter the integer for side 'b' of the triangle: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter the integer for side 'c' of the triangle: ");
            double sideC = double.Parse(Console.ReadLine());
            double p = (sideA + sideB + sideC) / 2;
            double areaTriangle = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"The area of the triangle, using Heron's formula, is {areaTriangle}");


            // Part 4
            Console.WriteLine("Part 4, solving a quadratic equation.");
            Console.Write("Enter the coefficient for 'a' of the equation: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the coefficient for 'b' of the equation: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the coefficient for 'c' of the equation: ");
            double c = double.Parse(Console.ReadLine());
            int x;

      /*      This is far as I was able to get on my own. We sort of went over it in class however it was all moving at a very fast speed.*/

        }
    }
}

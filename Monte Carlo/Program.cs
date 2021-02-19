using System;

namespace Monte_Carlo_Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInside = 0;
            int countOutside = 0;
            int iterations;
            iterations = int.Parse(args[0]); // 1,000
            for (int i = 0; i <= iterations; i++)
            {
                Random rng = new Random();
                (double x, double y) = RandomXY(rng);
                double hypotenuse = Hypotenuse(x, y);
                if (hypotenuse <= 1.0)
                {
                    countInside++;
                }
                else
                {
                    countOutside++;
                }
            }

            double myPi = 4.0 * countInside / iterations;
            double differencePi = Math.PI - myPi;

            Console.WriteLine($"\nThe actual value of pi is {Math.PI}");
            Console.WriteLine($"My estimated value of pi is {myPi}");
            Console.WriteLine($"The difference between these two is {differencePi}");
        }

        private static double Hypotenuse(double x, double y)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return hypotenuse;
        }

        private static (double x, double y) RandomXY(Random rng)
        {
            double x = rng.NextDouble();
            double y = rng.NextDouble();
            return (x, y);
        }
    }
}


/*Monte Carlo Questions
1.Why do we multiply the value from step 5 above by 4?
•	Within a graph there are for 1s. X coordinate can be 1 or -1. Y coordinate can be 1 or -1.

2.	What do you observe in the output when running your program with parameters of increasing size?
•	The larger the number for iterations the closer your output is to the actual value of PI.

3.	If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
•	No, because the numbers for the x and y coordinates are being randomly generated; therefore, creating different chances of landing before 1 or above 1.

4.	Find a parameter that requires multiple seconds of run time. What is that parameter?
•	1,000.000

5.	How accurate is the estimated value of pi?
•	More accurate when the number of iterations conducted is higher.

6.	Research one other use of Monte-Carlo methods. Describe it in your exercise submission.
•	There is a simulation using the Monte Carlo Method that helps to determine the probable stock price for that current day using the previous days input.
*/


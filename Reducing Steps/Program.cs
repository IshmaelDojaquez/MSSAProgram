using System;

namespace Reducing_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reducing Steps!!");
            int totalSteps = NumberOfSteps(123);
            Console.WriteLine($"The total number of steps was {totalSteps}");
        }

        private static int NumberOfSteps(int num)
        {
            int steps = 0;
            while(num > 0)
                if (num % 2 == 0)
                {
                    num = num / 2;
                    steps++;
                }
                else
                {
                    num = num - 1;
                    steps++;
                }
            return steps;
        }
    }
}



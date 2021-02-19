using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!!");
            int number = 0;

            for (number = 1; number <= 100; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine($"{number} FizzBuzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine($"{number} Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine($"{number} Fizz");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }
            }

        }
    }
}

using System;
using System.Linq;

namespace Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1

            int n = 0;
            int total = 0;
            int[] number = new int[10];

            for (n = 0; n < number.Length; n++)
            {
                Console.WriteLine("Enter a number between 0-100: ");
                number[n] = int.Parse(Console.ReadLine());                                      
                total++;
                Console.WriteLine($"Total {total}: {number.Sum()}");
                Console.WriteLine();
            }

            Console.WriteLine($"The sum of your numbers is: {number.Sum()}\n");



            //Part2

            int s = 0;
            int[] score = new int[10];

            for (s = 0; s < score.Length; s++)
            {
                Console.WriteLine("Enter your test score: ");
                score[s] = int.Parse(Console.ReadLine());
            }

            int average = score.Sum() / 10;

            if (average < 60)
            {
                Console.WriteLine("Current Grade: F");
            }
            if (average >= 60 && average < 70)
            {                                                                                      
                Console.WriteLine("Current Grade: D");
            }
            if (average >= 70 && average < 80)
            {
                Console.WriteLine("Current Grade: C");
            }
            if (average >= 80 && average < 90)
            {
                Console.WriteLine("Current Grade: B");
            }
            if (average >= 90)
            {
                Console.WriteLine("Current Grade: A");
            }

            Console.WriteLine($"The average of your test scores is: {average} %\n");


            //Part3
            Console.WriteLine("\nInput the total number of tests to be averaged: ");
            int numberOfTests = int.Parse(Console.ReadLine());
            Console.WriteLine($"There will be a total of {numberOfTests} tests: ");
            int t = 0;
            int[] tests = new int[numberOfTests];

            for (t = 0; t < tests.Length; t++)
            {
                Console.WriteLine("Enter your test score: ");
                tests[t] = int.Parse(Console.ReadLine());
            }

            int testsAverage = tests.Sum() / numberOfTests;

            if (testsAverage < 60)
            {
                Console.WriteLine("Current Grade: F");
            }
            if (testsAverage >= 60 && testsAverage < 70)
            {                                                                                       
                Console.WriteLine("Current Grade: D");
            }
            if (testsAverage >= 70 && testsAverage < 80)
            {
                Console.WriteLine("Current Grade: C");
            }
            if (testsAverage >= 80 && testsAverage < 90)
            {
                Console.WriteLine("Current Grade: B");
            }
            if (testsAverage >= 90)
            {
                Console.WriteLine("Current Grade: A");
            }

            Console.WriteLine($"The average of your test scores is: {testsAverage} %\n");

            //Part4
            //Need a concept of Lists. Learning that on my own accord; however, we were informed to stop after Part2.
            
        }
    }
}

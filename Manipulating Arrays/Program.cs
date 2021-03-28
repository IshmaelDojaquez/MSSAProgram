using System;
using System.Collections.Generic;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testA = { 0, 2, 4, 6, 8, 10 };
            int[] testB = { 1, 3, 5, 7, 9 };
            int[] testC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int testanswersum = Sum(testC);
            Console.WriteLine($"The sum is: {testanswersum}\n");

            int testansweraverage = Average(testB);
            Console.WriteLine($"The average is: {testansweraverage}\n");

            Reverse(testA);

            int testanswermaximum = Maximum(testB);
            Console.WriteLine($"The max number in this array is: {testanswermaximum}\n");

            RotatingArray(testB, 2);

            SortingArray(testC);
        }

        private static int Sum(int[] test)
        {

            int sum = 0;
            foreach (int val in test)
            {
                sum += val;
            }
            return sum;
        }
        private static int Average(int[] test)
        {
            int sum = Sum(test);
            int average = sum / test.Length;
            return average;
        }
        private static void Reverse(int[] test)
        {
            int[] newArray = new int[test.Length];
            int start = 0;
            int length = test.Length - 1;

            while (length >= 0)
            {
                newArray[length] = test[start];
                start++;
                length--;
            }

            Console.WriteLine("The reverse order of the array is below.");
            foreach (var item in newArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" ");
        }
        private static int Maximum(int[] test)
        {
            int largest = test[0];
            for (int i = 1; i < test.Length; i++)
            {
                if (test[i] > largest)
                {
                    largest = test[i];
                }
            }
            return largest;
        }
        private static void RotatingArray(int[] test, int rotation)
        {
            int[] newArray = new int[test.Length];
            int[] tempArray = new int[rotation];

            for (int i = 0; i < rotation; i++)
            {
                tempArray[i] = test[i];
            }

            for (int j = 0; j < test.Length - rotation; j++)
            {
                newArray[j] = test[rotation + j];
            }

            int start = 0;
            while (start != tempArray.Length)
            {
                newArray[test.Length - rotation] = tempArray[start];
                start++;
                rotation--;
            }

            Console.WriteLine("The rotated array is below.");
            foreach (var item in newArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" ");
        }

        private static void SortingArray(int[] test)
        {
            int[] newArray = new int[test.Length];
            int current;

            for (int i = 0; i < test.Length - 1; i++)  //3 1 4 1 5 9 2 6 5 3 5 
            {
                for (int j = i + 1; j < test.Length; j++) // 1 4 1 5 9 2 6 5 3 5 9 - 
                {
                    if (test[i] > test[j])
                    {
                        current = test[i];
                        test[i] = test[j];
                        newArray[j] = current;
                    }
                }
            }

            Console.WriteLine("The sorted array is below.");
            foreach (var item in test)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" ");
        }

    }
}


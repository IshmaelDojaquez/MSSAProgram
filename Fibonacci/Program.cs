using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci!!");
            int i = 0;
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            int c = 0;

            for (i = 0; i < 20; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}

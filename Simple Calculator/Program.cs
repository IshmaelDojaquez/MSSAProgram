using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = Conversion("Enter your first number: ");
            double number2 = Conversion("Enter your second number: ");
            Console.WriteLine("What operation would you like to use?");
            string operation = Console.ReadLine();



            switch (operation.ToUpper())
            {
                case "ADD":
                case "+":
                    double addition = number1 + number2;
                    Console.WriteLine($"{number1} + {number2} = {addition}");
                    break;

                case "SUB":
                case "-":
                    double subtraction = number1 - number2;
                    Console.WriteLine($"{number1} - {number2} = {subtraction}");
                    break;

                case "MUL":
                case "*":
                    double multiplication = number1 * number2;
                    Console.WriteLine($"{number1} * {number2} = {multiplication}");
                    break;

                case "DIV":
                case "/":
                    double division = number1 / number2;
                    Console.WriteLine($"{number1} / {number2} = {division}");
                    break;

                case "MOD":
                case "%":
                    double modulus = number1 - number2;
                    Console.WriteLine($"{number1} - {number2} = {modulus}");
                    break;

                default:
                    Console.WriteLine("I'm sorry. I don't know how to do that.");
                    break;
            }
        }
        private static double Conversion(string userInput)
        {
            Console.WriteLine(userInput);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
    }
}

using System;

namespace Cash_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchase = Conversion("Enter the purchase amount: ");
            double payment = Conversion("Enter the payment amount: ");
            double change = payment - purchase;
            while (change < 0)
            {
                Console.WriteLine("Customer did not pay with enough money... ");
                purchase = Conversion("\nPlease re-enter the purchase amount: ");
                payment = Conversion("\nPlease re-enter the payment amount: ");
                change = payment - purchase;
            }
            if (payment - purchase == 0)
            {
                Console.WriteLine("Customer paid with exact change.");
            }

            else if (payment > purchase)
            {
                Console.WriteLine($"\nCustomer's change  is ${change}.");
                ChangeSimplified(change);
            }

            Console.WriteLine("\nHave a good day!");
        }

        //All Methods Below

        private static double Conversion(string userInput)

        {
            double convertedPrice = 0;
            while (convertedPrice <= 0)
            {
                Console.WriteLine(userInput);
                try
                {
                    convertedPrice = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    convertedPrice = -1;
                }
                if (convertedPrice <= 0)
                {
                    Console.WriteLine($"Error... Input was not acceptable \n");
                }
            }
            return convertedPrice;
        }

        private static double ChangeMethod(double change, double denomination)
        {
            double amount = (int)(change / denomination);
            double refund = Math.Round(change, 2) % denomination;

            if (amount != 0)
                Console.WriteLine($"Hand customer ({amount}) {denomination}'s. Customer is now owed {Math.Round(refund, 2)}...");

            return refund;
        }

        private static void ChangeSimplified(double change)
        {
            double change20s = ChangeMethod(change, 20);
            double change10s = ChangeMethod(change20s, 10);
            double change5s = ChangeMethod(change10s, 5);
            double change1s = ChangeMethod(change5s, 1);
            double changeQuarters = ChangeMethod(change1s, .25);
            double changeDimes = ChangeMethod(changeQuarters, .10);
            double changeNickels = ChangeMethod(changeDimes, .05);
            double changePennies = ChangeMethod(changeNickels, .01);
        }
    }
}

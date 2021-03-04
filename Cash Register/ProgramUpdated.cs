using System;

namespace Cash_Register
{
    class Program
    {
        static void Main(string[] agrs)
        {
        StartPurchase:
            double purchase = Conversion("Enter the purchase amount: ");
         StartPayment:
            double payment = Conversion("Enter the payment amount: ");
            double change = payment - purchase;

            if (payment < purchase)
            {
                Console.WriteLine("\nCustomer has not paid with enough money...");
                goto StartPayment;  //Added additional goto statement to send user to the start of the process.
            }

            else if (payment - purchase == 0)
            {
                Console.WriteLine("Customer paid with exact change.");
            }

            else if (payment > purchase)
            {
                Console.WriteLine($"\nCustomer's change  is ${change}.");
                ChangeSimplified(change); // Created additional ChangeSimplified to shorten the code in Main
            }

            Console.WriteLine("\nHave a good day!");
        }
        
        //All Methods Below

            private static double Conversion(string userInput)
        {
            Console.WriteLine(userInput);
            double convertedPrice = Convert.ToDouble(Console.ReadLine());
            return convertedPrice;
        }

            private static double ChangeMethod(double change, double denomination) //Calculates the necessary change to customer
        {
            {
                double amount = (int)(change / denomination);
                double refund = Math.Round(change, 2) % denomination;

                if (amount != 0)
                    Console.WriteLine($"Hand customer ({amount}) {denomination}'s. Customer is now owed {Math.Round(refund, 2)}...");

                return refund;
            }
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
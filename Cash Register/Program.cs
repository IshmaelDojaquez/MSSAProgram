using System;

namespace Cash_Register
{
    class Program
    {
        //Part1 - Method for Question 1
               private static double PurchaseMethod()
               {
                   Console.WriteLine("Enter the purchase amount: $");
                   double purchase = Convert.ToDouble(Console.ReadLine());
                   return purchase;
               }
        
        
        //Part2 -Method for Question 2
               private static double PaymentMethod()
               {
                   Console.WriteLine("Enter your payment amount: $");
                   double payment = Convert.ToDouble(Console.ReadLine());
                   return payment;
               }


        //Part3 - Method for Question 3
        private static void ChangeMethod(double purchase, double payment)
        {
            double change = Math.Round((payment - purchase), 2);
            Console.WriteLine($"\nYour change is ${change}");

            double change20s = (int)change / 20;
            Console.WriteLine($"$20 returned to customer: {change20s}");
            change = change % 20;

            double change10s = (int)change / 10;
            Console.WriteLine($"$10 returned to customer: {change10s}");
            change = change % 10;

            double change5s = (int)change / 5;
            Console.WriteLine($"$5 returned to customer: {change5s}");
            change = change % 5;

            double change1s = (int)change / 1;
            Console.WriteLine($"$1 returned to customer: {change1s}");
            change = change % 1;

            double changeQuarters = Math.Round(change, 2) / .25;
            changeQuarters = (int)(changeQuarters);
            Console.WriteLine($"Quarters returned to customer: {changeQuarters}");
            change = change % .25;

            double changeDimes = Math.Round(change, 2) / .1;
            changeDimes = (int)(changeDimes);
            Console.WriteLine($"Dimes returned to customer: {changeDimes}");
            change = change % .1;

            double changeNickels = Math.Round(change, 2) / .05;
            changeNickels = (int)(changeNickels);
            Console.WriteLine($"Nickels returned to customer: {changeNickels}");
            change = change % .05;

            double changePennies = Math.Round(change, 2) / .01;
            changePennies = (int)(changePennies);
            Console.WriteLine($"Pennies returned to customer: {changePennies}");
            Console.WriteLine("\n -------------------------------");
        }


        //Part4 - Conversion Method for Question 4
        private static double Conversion(string userInput)
        {
            Console.WriteLine(userInput);
            double conversion = Convert.ToDouble(userInput);
            return conversion;
        }


        //Part5 Change Method for Question 5
        private static double ChangeMethod1(double change, double denomination)
        {
            {
                double amount = (int)(change / denomination);
                double refund = Math.Round(change, 2) % denomination;

                if (amount != 0)
                    Console.WriteLine($"Hand customer ({amount}) {denomination}'s. Customer is now owed {Math.Round(refund,2)}...");

                return refund;
            }
        }

        static void Main(string[] agrs)
        {
            //Code for Question 1,2,3
            double purchase = PurchaseMethod();
            double payment = PaymentMethod();
            ChangeMethod(purchase, payment);

            //Code for Question 4
            double purchaseConversion1 = Conversion("Enter the purchase amount: ");
            double paymentConversion1 = Conversion("Enter the payment amount: ");
            ChangeMethod(purchaseConversion1, paymentConversion1);

            //Code for Question 5
            Console.WriteLine("Enter the purchase amount: ");
            string purchase2 = Console.ReadLine();
            double purchaseConversion2 = Conversion(purchase2);
            Console.WriteLine("Enter the payment amount: ");
            string payment2 = Console.ReadLine();
            double paymentConversion2 = Conversion(payment2);
            double change = paymentConversion2 - purchaseConversion2;
            Console.WriteLine($"\nYour change  is ${change}");
            double change20s = ChangeMethod1(change, 20);
            double change10s = ChangeMethod1(change20s, 10);
            double change5s = ChangeMethod1(change10s, 5);
            double change1s = ChangeMethod1(change5s, 1);
            double changeQuarters = ChangeMethod1(change1s, .25);
            double changeDimes = ChangeMethod1(changeQuarters, .10);
            double changeNickels = ChangeMethod1(changeDimes, .05);
            double changePennies = ChangeMethod1(changeNickels, .01);
        }
    }
}

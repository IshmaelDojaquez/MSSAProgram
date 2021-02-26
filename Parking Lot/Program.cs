using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates first parking lot
            ParkingLot ParkingLot1 = new ParkingLot();

            //Set the amount of spaces in the parking lot
            ParkingLot1.SetLargeCar(3);
            ParkingLot1.SetMediumCar(5);
            ParkingLot1.SetSmallCar(9);
            Console.WriteLine($"The parking garage now has {ParkingLot1.GetLargeCar()} large spots, {ParkingLot1.GetMediumCar()} medium spots, and {ParkingLot1.GetSmallCar()} small spots.");

            //Add cars to parking lot
            ParkingLot1.AddCar("Large");
            ParkingLot1.AddCar("Large");
            ParkingLot1.AddCar("Large");
            Console.WriteLine($"The parking garage now has {ParkingLot1.GetLargeCar()} large spots.");
            //No large spots remaining in parking garage. Iterating again to return false.
            ParkingLot1.AddCar("Large");
            ParkingLot1.AddCar("Medium");
            ParkingLot1.AddCar("Medium");
            ParkingLot1.AddCar("Medium");
            Console.WriteLine($"The parking garage now has {ParkingLot1.GetMediumCar()} medium spots.");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            ParkingLot1.AddCar("Small");
            //No small spots remaining in parking garage. Iterating again to return false.
            Console.WriteLine($"The parking garage now has {ParkingLot1.GetSmallCar()} small spots.");
            ParkingLot1.AddCar("Small");

        }
    }
}

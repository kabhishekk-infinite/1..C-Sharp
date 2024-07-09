using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Welcome to the Vehicle Information System!");
            Console.WriteLine("Please enter the type of vehicle you want details for (REGULAR/SPORTS):");
            string input = Console.ReadLine().ToUpper();

            // Validate input and display vehicle details accordingly
            if (input == "REGULAR")
            {
                DisplayVehicleDetails(new RegularVehicleFactory(), "Regular Vehicles");
            }
            else if (input == "SPORTS")
            {
                DisplayVehicleDetails(new SportsVehicleFactory(), "Sports Vehicles");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter either 'REGULAR' or 'SPORTS'.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void DisplayVehicleDetails(IVehicleFactory factory, string vehicleType)
        {
            IBike bike = factory.CreateBike();
            ICar car = factory.CreateCar();

            Console.Clear(); // Clear the console for a clean display
            Console.WriteLine("====================================");
            Console.WriteLine($"      {vehicleType}");
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.WriteLine("Bike Details:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(bike.GetBikeDetails());
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Car Details:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(car.GetCarDetails());
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }
    }

}

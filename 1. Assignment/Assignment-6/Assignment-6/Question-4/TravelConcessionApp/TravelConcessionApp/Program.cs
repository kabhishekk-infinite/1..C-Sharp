using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelConcessionLibrary;

namespace TravelConcessionApp
{
    class Program
    {
        private const decimal TotalFare = 500m;

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                ConcessionCalculator calculator = new ConcessionCalculator();
                string result = calculator.CalculateConcession(age);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid number.");
            }

            Console.ReadKey();
        }
    }
}

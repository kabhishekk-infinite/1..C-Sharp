using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Write a console program that uses delegates to call Calculator Functionalities like 1. Addition, 2. Subtraction and 3. Multiplication
// By taking 2 integers and returns the answer to the user. You should display all the return values accordingly.


namespace CCA_4
{
    // Define delegate types for operations
    delegate int CalculatorDelegate(int a, int b);

    class Delegates_Functions
    {
        static void Main()
        {
            //Create Instances of Delegates for all different operations.
            CalculatorDelegate addition = (a, b) => a + b;
            CalculatorDelegate subtraction = (a, b) => a - b;
            CalculatorDelegate multiplication = (a, b) => a * b;

            //Input values
            int num1, num2;
            Console.WriteLine("Enter the First Number:");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid Integer:");
            }

            Console.WriteLine("Enter the Second Number:");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid Integer:");
            }

            Console.WriteLine(" ");

            // Perform ADD
            int resultAddition = PerformOperation(addition, num1, num2);
            Console.WriteLine($"Addition: {num1} + {num2} = {resultAddition}");

            // Perform SUB
            int resultSubtraction = PerformOperation(subtraction, num1, num2);
            Console.WriteLine($"Subtraction: {num1} - {num2} = {resultSubtraction}");

            // Perform MULTI
            int resultMultiplication = PerformOperation(multiplication, num1, num2);
            Console.WriteLine($"Multiplication: {num1} * {num2} = {resultMultiplication}");


            Console.WriteLine(" ");
            Console.WriteLine("~ ~ ~ Over ~ ~ ~ ");
            Console.WriteLine("Press any ekey to Exit. ");
            Console.ReadKey();


        }

        //Method to perform Operations using Delegate
        static int PerformOperation(CalculatorDelegate operation, int a, int b)
        {
            return operation(a, b);
        }
    }
}

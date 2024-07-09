using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Prog that takes two Numbers as Input from User and performs Calculations (+,/,-,*) on them and Display the Result.
// => Input from User [2 nums] --> Perform Calculation [+,-,*,/] --> Display Result.


namespace Assignment_1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");                              //Enter First Number.
            double num1 = Convert.ToDouble(Console.ReadLine());                     //Takes string as input, then converts strings into Integer.

            Console.Write("\nEnter The Second Number : ");                          //Enter Second Number.
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the operations
            double sum = num1 + num2;                                               //SUM  [a + b]
            double difference = num1 - num2;                                        //DIFF [a - b]
            double product = num1 * num2;                                           //PROD [a * b]
            double quotient = 0;                                                    //DIVD [a / b]

            // Check for division by zero
            if (num2 != 0)
            {
                quotient = num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Display Result : 
            Console.WriteLine("\n Results :--");
            Console.WriteLine("\n   Sum: " + sum);
            Console.WriteLine("\n   Difference: " + difference);
            Console.WriteLine("\n   Product: " + product);
            if (num2 != 0)
            {
                Console.WriteLine("\n   Quotient: " + quotient);
            }


            Console.WriteLine("\n");
            Console.WriteLine(" ~  ~  ~  ~  ~ END OF PROGRAM ~  ~  ~  ~  ~     ");
            Console.WriteLine(" ~  ~  ~ Programs Executed Sucessfully ~  ~  ~  ");
            Console.WriteLine("");
            Console.WriteLine("~ ~ ~ ~ ~ Please Click Any Key To Exit ~ ~ ~ ~ ~");
            Console.ReadKey();
        }
    }
}

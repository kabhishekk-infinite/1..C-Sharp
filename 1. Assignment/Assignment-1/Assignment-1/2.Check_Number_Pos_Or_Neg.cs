using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Prog that Check whether a given number is Positive or Negative and Display the Result.
// => Check given number --> Positive or Negative --> Display Result.


namespace Assignment_1
{
    class Check_Number_Pos_Or_Neg
    {
        static void Main(string[] args)
        {
            //Given Number 1 : Is Negative.
            int num1 = -27;

            // Check 
            if (num1 > 0)
            {
                Console.WriteLine($"The number {num1} is positive.");
            }
            else if (num1 < 0)
            {
                Console.WriteLine($"The number {num1} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num1} is zero.");
            }

            Console.WriteLine("");

            Console.WriteLine("Press any key to check with another number.\n");
            Console.ReadKey();

            //Given Number 2 : Is zero.
            int num2 = 0;

            // Check 
            if (num2 > 0)
            {
                Console.WriteLine($"The number {num2} is positive.");
            }
            else if (num2 < 0)
            {
                Console.WriteLine($"The number {num2} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num2} is zero.");
            }

            Console.WriteLine("");

            Console.WriteLine("Press any key to check with another number.\n");
            Console.ReadKey();

            //Given Number 3 : Is Positive.
            int num3 = 15;

            // Check 
            if (num3 > 0)
            {
                Console.WriteLine($"The number {num3} is positive.");
            }
            else if (num3 < 0)
            {
                Console.WriteLine($"The number {num3} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num3} is zero.");
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

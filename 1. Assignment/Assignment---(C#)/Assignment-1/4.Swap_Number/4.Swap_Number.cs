using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. program to Swap two Numbers and Display the Result.
// => n1, n2 --> swap value of n1 and n2 --> Display Result.

namespace _4.Swap_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter The First Number: ");                              //Enter First Number.
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter The Second Number: ");                             //Enter Second Number.
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore swapping: num1 = " + num1 + ", num2 = " + num2);

            // Swap 
            int temp = num1;                      //store value of num1 to temp. temp has num1 value and num1 is empty.
            num1 = num2;                          //store value of num2 to num1. num1 has num2 value and num2 is empty.
            num2 = temp;                          //store value of temp to num2. num2 has temp value i.e.,num1 value and temp is empty.


            //Print num1 and num2 with swap value. 
            Console.WriteLine($"\nAfter  swapping: num1 = {num1}, num2 = {num2} ");


            Console.WriteLine("\n");
            Console.WriteLine(" ~  ~  ~  ~  ~ END OF PROGRAM ~  ~  ~  ~  ~     ");
            Console.WriteLine(" ~  ~  ~ Programs Executed Sucessfully ~  ~  ~  ");
            Console.WriteLine("");
            Console.WriteLine(" ~  ~  ~  ~  ~ END OF OUTPUT ~  ~  ~  ~  ~      ");
            Console.WriteLine(" ~  ~  Output Generated & Results are Out  ~  ~ ");
            Console.WriteLine("\n");
            Console.WriteLine("~ ~ ~ ~ ~ Please Click Any Key To Exit ~ ~ ~ ~ ~");
            Console.ReadKey();

        }
    }
}

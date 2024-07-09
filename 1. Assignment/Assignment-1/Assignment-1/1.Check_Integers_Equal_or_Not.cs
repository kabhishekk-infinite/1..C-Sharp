using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Prog that takes two numbers as Input from User and Check whether they are Equal or Not and Display the Result.
// => Take Input [2 nums] --> Check that both are Equal or not --> Display Result.  

namespace Assignment_1
{
    class Check_Integers_Equal_or_Not
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");              //Enter First Number.
            String str = Console.ReadLine();                        //Takes string as input,
            int num1 = Convert.ToInt32(str);                        //Then converts strings into Integer.

            Console.Write("Enter The Second Number : ");            //Enter Second Number
            int num2 = Convert.ToInt32(Console.ReadLine());         //Same process but function written in single line.

            // Check Both are Equal or Not
            if (num1 == num2)
            {
                Console.WriteLine($"The Numbers are Equal. \nBoth numbers are : {num1} , {num2}.");
            }
            else
            {
                Console.WriteLine($"The Numbers are not Equal. \nBoth numbers are : {num1} , {num2}.");
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
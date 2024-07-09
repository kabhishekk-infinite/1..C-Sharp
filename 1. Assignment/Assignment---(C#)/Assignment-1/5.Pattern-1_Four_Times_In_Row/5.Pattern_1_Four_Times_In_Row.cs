using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Program that takes a Numbers as Input from User and Displays it Four Times in a row Separated by Blank Space and then Four Times in the next Row, Without any Separation.     
//    You should do it twice: Use the Console. Write and use {0}.
// => Take a num as Input --> Display num in Pattern-1 --> Also use {0} for Pattern.

namespace _5.Pattern_1_Four_Times_In_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter 3 numbers to print pattern in 3 diff format.
            Console.Write("Enter a Number 1 : ");
            string input1 = Console.ReadLine();                     //Taking Input as String later in line 25 it will be coverted.

            Console.Write("Enter a Number 2 : ");
            int input2 = int.Parse(Console.ReadLine());              //Taking Input as String but changing it to int.

            Console.Write("Enter a Number 3 : ");
            int input3 = Convert.ToInt32(Console.ReadLine());           //Taking Input as String but converting into int here.


            //Pattern From Number 1
            if (int.TryParse(input1, out int number))           //It will convert the string to int. Also it first returns boolean value that entered number is int or Not.
            {                                                   // Here input1 converted to number(in int form).
                Console.WriteLine("\t \n Pattern Number : 1 \n");
                Console.WriteLine(string.Format("\t {0} {0} {0} {0}", number));     //Using {0} for printing 'number' value.
                Console.WriteLine(string.Format("\t {0}{0}{0}{0}", number));
                Console.WriteLine(string.Format("\t {0} {0} {0} {0}", number));
                Console.WriteLine(string.Format("\t {0}{0}{0}{0}", number));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            //Pattern From Number 2
            Console.WriteLine("\t \n Pattern Number : 2 \n");               //Using Simple print statement to print pattern.

            Console.WriteLine($"\t {input2} {input2} {input2} {input2}");
            Console.WriteLine($"\t {input2}{input2}{input2}{input2}");
            Console.WriteLine($"\t {input2} {input2} {input2} {input2}");
            Console.WriteLine($"\t {input2}{input2}{input2}{input2}");

            //Pattern From Number 3
            Console.WriteLine("\t \n Pattern Number : 3 \n");               //Using for loop to print Pattern.
            for (int i = 2; i < 6; i++)
            {
                Console.Write("\t ");

                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(input3 + " ");
                    }
                    else
                    {
                        Console.Write(input3);
                    }
                }
                Console.WriteLine("");
            }


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

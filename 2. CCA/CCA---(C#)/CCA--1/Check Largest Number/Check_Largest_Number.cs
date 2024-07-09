using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Largest_Number
{


            static void Main(string[] args)
            {
                Console.Write("Enter first integer: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter third integer: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int largnum = largestNum(num1, num2, num3);

                Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is: {largnum}");


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  Programs Execute Sucessfully.     ");
                Console.WriteLine("");
                Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~     ");
                Console.WriteLine(" Please Click Any Key To Exit.    ");
                Console.ReadKey();
            }

            static int largestNum(int a, int b, int c)
            {
                int largest = Math.Max(a, Math.Max(b, c));
                return largest;
            }
        }

   
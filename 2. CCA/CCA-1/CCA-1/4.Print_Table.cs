using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_1
{
    class Print_Table
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num1}: ");
            for (int i = 1; i <= 10; i++)
            {
                int mul = num1 * i;
                //Display Output
                Console.WriteLine($"{num1} * {i} = {mul}");



            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ Programs Execute Sucessfully. ~ ~ ~ ~ ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();
        }
    }
}

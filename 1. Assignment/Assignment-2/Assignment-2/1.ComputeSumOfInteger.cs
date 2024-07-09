using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ComputeSumOfInteger
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Enter two Integers :- ");
              int num5 = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter two Integers :- ");
              int num6 = int.Parse(Console.ReadLine()); */

            int num5 = 20;
            int num6 = 25;

            int sum;

            sum = num5 + num6;

            if (num5 == num6)
            {
                Console.WriteLine($" Both The Numbers are Same : {num5} {num6}. \n Now Triple of Their Sum is : {sum * 3}   ");
            }
            else
            {
                Console.Write($" The Numbers are not Same : {num5} {num6}. \n Now The Sum of both Numbers are {sum} ");
            }
            Console.ReadKey();
        }
    }
}

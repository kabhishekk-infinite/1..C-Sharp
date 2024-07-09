using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class NameOfDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number (1-7):");
            int dayNumber = int.Parse(Console.ReadLine());

            //Condition for day check
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Monday ");
                    break;
                case 2:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Tuesday ");
                    break;
                case 3:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Wednesday ");
                    break;
                case 4:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Thursday ");
                    break;
                case 5:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Friday ");
                    break;
                case 6:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Saturday ");
                    break;
                case 7:
                    Console.WriteLine($" Day number is {dayNumber} \n therefore day name is : Sunday ");
                    break;
                default:
                    Console.WriteLine(" Day number didn't match ");
                    break;
            }

            Console.ReadKey();

        }
    }
}
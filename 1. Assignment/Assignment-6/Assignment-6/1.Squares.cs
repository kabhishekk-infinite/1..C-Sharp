using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Squares
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of numbers separated by commas :");
            string input = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("List of Numbers and Their Squares :- ");
            Console.WriteLine(""); 

            //Parse the input string into a list of integers
            List<int> numbers = input.Split(',').Select(int.Parse).ToList();

            //Create a query to get numbers and their squares only if the square is greater than 20
            var result = from number in numbers
                         let square = number * number
                         where square > 20
                         select new { Number = number, Square = square };

            //Print the result
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }

            Console.ReadKey();
        }
    }
}

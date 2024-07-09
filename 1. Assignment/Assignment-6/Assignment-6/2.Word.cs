using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Word
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words separated by commas :");
            string input = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("The Word Starting with letter 'a' and ending with letter 'm' are :-- ");
            Console.WriteLine(" ");

            //Parse the input string into a list of words
            List<string> words = input.Split(',').Select(word => word.Trim()).ToList();

            //Create a query to get words starting with 'a' and ending with 'm'
            var result = from word in words
                         where word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase)
                         select word;

            //Print the result
            foreach (var word in result)
            {
               
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}

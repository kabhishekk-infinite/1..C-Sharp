using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSameOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            bool areEqual = word1.Equals(word2, StringComparison.OrdinalIgnoreCase);

            if (areEqual)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }
            Console.ReadKey();
        }
    }
}

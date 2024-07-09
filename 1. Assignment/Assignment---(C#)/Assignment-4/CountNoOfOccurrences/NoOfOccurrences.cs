using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Number_Of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write(" Enter The String  :  ");
            string str = Console.ReadLine();

            //Input
            Console.Write(" Enter The Letter you want to COUNT the No. of Occurrences :  ");
            char chr = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //Calling NoOfOccurrences methods
            int count = NoOfOccurrences(str, chr);

            //Display Result
            Console.WriteLine($"\n The Letter '{chr}', Occurrs '{count}' times in String '{str}' ");

            /* ~ ~ ~ ~ These are only for Decoration Perpose ~ ~ ~ ~ */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ Programs Execute Sucessfully ~ ~    ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~            ");
            Console.WriteLine(" Please Click Any Key To Exit.           ");
            Console.ReadKey();
        }



        //Method to count occurrences of a letter
        static int NoOfOccurrences(string str, char chr)
        {
            int count = 0;  //'count' will Count the no. of occurrences.
            foreach (char c in str)
            {
                if (char.ToLower(c) == char.ToLower(chr))   //For Ensure Case Insensitivity
                {
                    count++;
                }
            }
            return count;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_1
{
    class Exchange_Char
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string newstr = swapchar(str);

            //Display Output
            Console.WriteLine($"Original String: {str}");
            Console.WriteLine($"After exchanging first and last characters: {newstr}");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ Programs Execute Sucessfully. ~ ~ ~ ~ ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();
        }

        static string swapchar(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length == 1)
            {
                return str;
            }

            char Charfirst = str[0];
            char Charlast = str[str.Length - 1];
            char[] charArray = str.ToCharArray();
            charArray[0] = Charlast;
            charArray[str.Length - 1] = Charfirst;
            string result = new string(charArray);

            return result;
        }
    }
}

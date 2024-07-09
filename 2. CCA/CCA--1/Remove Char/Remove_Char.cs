using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a string : ");
            string str = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the position of character : ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            string resultstr = newstring(str, pos);
            Console.WriteLine($"After removing : {resultstr}");

            Console.WriteLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Programs Execute Sucessfully.    ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~     ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();

        }
        static string newstring(string str, int index)
        {
            if (index < 0 || index >= str.Length)
            {
                return str;
            }

            return str.Remove(index, 1);
        }
    }
}




/*          Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Programs Execute Sucessfully.    ");
            Console.WriteLine("");
            Console.WriteLine(" To View More Programs Check Next File. ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~     ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();
*/
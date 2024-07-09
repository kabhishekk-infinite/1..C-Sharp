using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_2
{
    class NegativeIntegerAsException
    {
        static void Main(string[] args)
        {
            try
            {
                //Input Integer.
                Console.Write(" Enter an integer: ");
                int num = int.Parse(Console.ReadLine());

                //This CHeck Method will check if the imput number is Negative or Not.
                CheckForNegativeInteger(num);

                //Display this if number is positive.
                Console.WriteLine($" Entered number: {num}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($" ArgumentException caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Exception caught: {ex.Message}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ Programs Execute Sucessfully. ~ ~ ~ ~ ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();
        }

        static void CheckForNegativeInteger(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException(" Number Can't Be Negative. ");       //Exception Message.
            }

        }
    }
}

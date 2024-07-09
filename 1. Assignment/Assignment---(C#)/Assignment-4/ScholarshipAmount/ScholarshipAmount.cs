using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Create a class called Scholarship which has a function Public void Merit() that takes marks and fees as an input. 
// If the given mark is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
// If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
// If the given mark is >90, then calculate scholarship amount as 50% of the fees.
// In all the cases return the Scholarship amount




namespace ScholarshipAmount
{
    public class Scholarship
    {
        public double Merit(int marks, double fees)             //To check , Merit eligibility.
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2 * fees; // 20% of fees
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees; // 30% of fees
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees; // 50% of fees
            }
            else
            {
                throw new ArgumentException("Invalid marks. Marks should be between 70 and 100.");
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Scholarship scholarship = new Scholarship();

                // Test cases : 1
                int marks1 = 75;
                double fees1 = 10000;
                Console.WriteLine($"Marks: {marks1}, Fees: ${fees1}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks1, fees1)}");
                Console.WriteLine("");

                // Test cases : 2
                int marks2 = 85;
                double fees2 = 12000;
                Console.WriteLine($"Marks: {marks2}, Fees: ${fees2}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks2, fees2)}");
                Console.WriteLine("");

                // Test cases : 3
                int marks3 = 95;
                double fees3 = 15000;
                Console.WriteLine($"Marks: {marks3}, Fees: ${fees3}");
                Console.WriteLine($"Scholarship Amount: ${scholarship.Merit(marks3, fees3)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }


        /* ~ ~ ~ ~ These are only for Decoration Perpose ~ ~ ~ ~ */
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" ~ ~ Programs Execute Sucessfully ~ ~ ");
                Console.WriteLine("");
                Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~         ");
                Console.WriteLine(" Please Click Any Key To Exit.        ");
                Console.ReadKey();
        }
    }
}

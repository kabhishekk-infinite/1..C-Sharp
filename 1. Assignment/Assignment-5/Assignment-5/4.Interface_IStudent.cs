using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    // Define the IStudent Interface
    public interface IStudent
    {
        // Properties : 
        int StudentId { get; set; }
        string Name { get; set; }

        // Method
        void ShowDetails();
    }

    // Class Dayscholar 
    public class Dayscholar : IStudent                          //Implementing IStudent interface
    {
        // Properties from IStudent interface
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Implementing the method from IStudent interface
        public void ShowDetails()
        {
            Console.WriteLine("Dayscholar Details:");
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Name: {0}", Name);
        }
    }

    // Class 'Resident' Implementing IStudent interface
    public class Resident : IStudent
    {
        // Properties from IStudent Interface
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Implementing the method from IStudent Interface
        public void ShowDetails()
        {
            Console.WriteLine("Resident Details:");
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Name: {0}", Name);
        }
    }

    // Test class to execute the above
    class Interface_IStudent_Test
    {
        static void Main()
        {
            // Creating instances of Dayscholar and Resident
            IStudent dayscholar = new Dayscholar { StudentId = 19006, Name = "Abhishek Kumar" };
            IStudent resident = new Resident { StudentId = 1035480, Name = "Abhishek Kumar" };

            // Calling ShowDetails method to display student details
            dayscholar.ShowDetails();
            Console.WriteLine();

            resident.ShowDetails();

            /* ~ ~ ~ ~ These are only for Decoration Perpose ~ ~ ~ ~ */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ Programs Execute Sucessfully ~ ~    ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~            ");
            Console.WriteLine(" Please Click Any Key To Exit.           ");
            Console.ReadKey();

        }
    }
}

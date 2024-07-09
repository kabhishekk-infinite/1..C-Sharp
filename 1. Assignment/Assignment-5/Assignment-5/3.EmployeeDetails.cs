using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    // Base class ' Employee '
    class Employee
    {
        // Properties : 
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        // Constructor to Initialize.
        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        // Method to Display - Employee Details.
        public void Display()
        {
            Console.WriteLine("Employee ID: {0}", Empid);
            Console.WriteLine("");
            Console.WriteLine("Employee Name: {0}", Empname);
            Console.WriteLine("");
            Console.WriteLine("Salary: {0}", Salary);
            Console.WriteLine("");
        }
    }

    // Derived class 'ParttimeEmployee'  Inheriting from 'Employee'.
    class ParttimeEmployee : Employee
    {
        // Additional Member specific to 'ParttimeEmployee'.
        public float Wages { get; set; }

        // Constructor to Initialize base class Employee and Wages
        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }

        // Method to Display Part-Time Employee details
        public new void Display()                             // Using 'new' to hide base class Display() method
        {
            base.Display();                                  // Call base class method to display Empid, Empname, and Salary
            Console.WriteLine("Wages: {0}", Wages);         // Display Wages specific to ParttimeEmployee
        }
    }

    // Test class to execute the above
    class EmployeeDetails_Test
    {
        static void Main()
        {
            // Create an instance of 'ParttimeEmployee'.
            ParttimeEmployee partTimeEmp = new ParttimeEmployee(1035480, "Mr. Abhishek Kumar", 30000, 15);

            // Display Part-time Employee details
            Console.WriteLine("Part-time Employee Details:");
            Console.WriteLine("");
            partTimeEmp.Display();


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

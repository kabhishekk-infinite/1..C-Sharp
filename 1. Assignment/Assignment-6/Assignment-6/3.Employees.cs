using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }

    class Employees
    {
        static void Main()
        {
            //Creating and populating the list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Abhishek Kumar", EmpCity = "Bangalore", EmpSalary = 60000 },
            new Employee { EmpId = 2, EmpName = "Ankit Kumar", EmpCity = "Mumbai", EmpSalary = 45000 },
            new Employee { EmpId = 3, EmpName = "Om Verma", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 4, EmpName = "Bishnu", EmpCity = "Chennai", EmpSalary = 40000 },
            new Employee { EmpId = 5, EmpName = "Vivek", EmpCity = "Bangalore", EmpSalary = 55000 }
        };

            //To display all employees data
            Console.WriteLine("All employees data:-- ");
            DisplayEmployees(employees);

            //To display all employees data whose salary is greater than 45000
            Console.WriteLine("\nEmployees with salary greater than 45000:-- ");
            DisplayEmployees(employees.Where(emp => emp.EmpSalary > 45000).ToList());

            //To display all employees data who belong to Bangalore Region
            Console.WriteLine("\nEmployees from Bangalore:-- ");
            DisplayEmployees(employees.Where(emp => emp.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase)).ToList());

            //To display all employees data by their names in ascending order
            Console.WriteLine("\nEmployees sorted by name (ascending order):-- ");
            DisplayEmployees(employees.OrderBy(emp => emp.EmpName).ToList());

            Console.ReadKey();
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
            }
        }
    }
}

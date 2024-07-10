using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


// 3. Create a Generic List Collection empList and populate it with the following records.
// Now once the collection is created write down and execute the LINQ queries for collection  as follows :
//       a. Display detail of all the employee
//       b. Display details of all the employee whose location is not Mumbai
//       c. Display details of all the employee whose title is AsstManager
//       d. Display details of all the employee whose Last Name start with S

namespace CCA_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Employee class to represent each employee record
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; } 
        public DateTime DOJ { get; set; }  
        public string City { get; set; }
    }

    class Generic_List
    {
        static void Main()
        {
            //Create a List to store Employee objects
            List<Employee> empList = new List<Employee>();

            //Populate the empList with employee records
            empList.Add(new Employee
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = new DateTime(1984, 11, 16),  // Year, Month, Day
                DOJ = new DateTime(2011, 6, 8),    // Year, Month, Day
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = new DateTime(1984, 8, 20),   // Year, Month, Day
                DOJ = new DateTime(2012, 7, 7),    // Year, Month, Day
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = new DateTime(1987, 11, 14),  // Year, Month, Day
                DOJ = new DateTime(2015, 4, 12),   // Year, Month, Day
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1990, 6, 3),    // Year, Month, Day
                DOJ = new DateTime(2016, 2, 2),    // Year, Month, Day
                City = "Pune"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1991, 3, 8),    // Year, Month, Day
                DOJ = new DateTime(2016, 2, 2),    // Year, Month, Day
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = new DateTime(1989, 11, 7),   // Year, Month, Day
                DOJ = new DateTime(2014, 8, 8),    // Year, Month, Day
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = new DateTime(1989, 12, 2),   // Year, Month, Day
                DOJ = new DateTime(2015, 6, 1),    // Year, Month, Day
                City = "Mumbai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = new DateTime(1993, 11, 11),  // Year, Month, Day
                DOJ = new DateTime(2014, 11, 6),   // Year, Month, Day
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = new DateTime(1992, 8, 12),   // Year, Month, Day
                DOJ = new DateTime(2014, 12, 3),   // Year, Month, Day
                City = "Chennai"
            });

            empList.Add(new Employee
            {
                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = new DateTime(1991, 4, 12),   // Year, Month, Day
                DOJ = new DateTime(2016, 1, 2),    // Year, Month, Day
                City = "Pune"
            });

            // Now execute LINQ queries on empList
            DisplayAllEmployees(empList);
            DisplayEmployeesNotInMumbai(empList);
            DisplayAsstManagers(empList);
            DisplayEmployeesWithLastNameStartingWithS(empList);

            Console.WriteLine(" ");
            Console.WriteLine("~ ~ ~ Over ~ ~ ~ ");
            Console.WriteLine("Press any ekey to Exit. ");
            Console.ReadKey();

        }

        // A. Method to display all employees
        static void DisplayAllEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
        }

        // B. Method to display employees whose location is not Mumbai
        static void DisplayEmployeesNotInMumbai(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.City != "Mumbai").ToList();
            Console.WriteLine("\nEmployees Not in Mumbai:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
        }

        // C. Method to display employees whose title is AsstManager
        static void DisplayAsstManagers(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.Title == "AsstManager").ToList();
            Console.WriteLine("\nAsstManagers:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
        }

        // D. Method to display employees whose Last Name starts with S
        static void DisplayEmployeesWithLastNameStartingWithS(List<Employee> employees)
        {
            var result = employees.Where(emp => emp.LastName.StartsWith("S")).ToList();
            Console.WriteLine("\nEmployees with Last Name starting with S:");
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
        }
    }
}



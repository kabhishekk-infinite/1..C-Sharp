﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{

    public abstract class Student           //Class name Student (Abstract class).
    {
        //Properties
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);         //Abstract method
    }

    //Subclass 'Undergraduate' class inheriting from Student.
    public class Undergraduate : Student
    {
        //Override IsPassed method
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    //Subclass 'Graduate' class inheriting from Student.
    public class Graduate : Student
    {
        //Override IsPassed method
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            // Test the classes
            Undergraduate UGStudent = new Undergraduate
            {
                Name = "Abhishek Kumar",
                StudentId = 1035480,
                Grade = 75.0
            };

            Graduate GStudent = new Graduate
            {
                Name = "Abhishek Kumar",
                StudentId = 1035480,
                Grade = 85.0
            };

            // Test IsPassed method for Undergraduate
            Console.WriteLine($"Undergraduate Student - Name: {UGStudent.Name}, ID: {UGStudent.StudentId}, Grade: {UGStudent.Grade}");
            Console.WriteLine($"Is Passed: {UGStudent.IsPassed(UGStudent.Grade)}");

            Console.WriteLine();

            // Test IsPassed method for Graduate
            Console.WriteLine($"Graduate Student - Name: {GStudent.Name}, ID: {GStudent.StudentId}, Grade: {GStudent.Grade}");
            Console.WriteLine($"Is Passed: {GStudent.IsPassed(GStudent.Grade)}");

            Console.ReadLine();
        }
    }
}

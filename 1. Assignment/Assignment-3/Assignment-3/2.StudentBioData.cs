using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student
    {
        //Data members
        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        //Constructor- To Initialize Student details
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        //Method- Input 5 Subjects Marks.
        public void GetMarks(int[] marks)
        {
            if (marks.Length == 5)
            {
                Array.Copy(marks, this.marks, 5);
            }
            else
            {
                throw new ArgumentException("Marks should be provided for all 5 subjects.");
            }
        }

        //Method- Calc Average Marks & Display Result.
        public void DisplayResult()
        {
            double averageMarks = CalculateAverageMarks();

            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");

            if (CheckFailedSubjects())
            {
                Console.WriteLine("Result: Failed (Marks of one or more subjects are less than 35)");
            }
            else if (averageMarks < 50)
            {
                Console.WriteLine($"Average Marks: {averageMarks}");
                Console.WriteLine("Result: Failed (Average marks are less than 50)");
            }
            else
            {
                Console.WriteLine($"Average Marks: {averageMarks}");
                Console.WriteLine("Result: Passed");
            }
        }

        //Method- Display All Student Data.
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
        }

        private double CalculateAverageMarks()
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum / 5;
        }

        private bool CheckFailedSubjects()
        {
            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class StudentBioData
    {
        static void Main()
        {
            Student student1 = new Student(10, "Abhishek Kumar", "10th", "First", "Computer");
            int[] marks1 = { 70, 65, 80, 45, 60 };
            student1.GetMarks(marks1);
            student1.DisplayData();
            Console.WriteLine();
            student1.DisplayResult();

            Console.WriteLine();

            Student student2 = new Student(20, "Ankit Kumar", "10th", "First", "Science");
            int[] marks2 = { 40, 50, 60, 55, 45 };
            student2.GetMarks(marks2);
            student2.DisplayData();
            Console.WriteLine();
            student2.DisplayResult();

            Console.ReadLine();
        }
    }
}

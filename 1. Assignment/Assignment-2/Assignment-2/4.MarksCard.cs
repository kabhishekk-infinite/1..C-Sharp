using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class MarksCard
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter your Mark {0}: ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }

            double average = (double)total / marks.Length;

            int minMarks = marks[0];
            foreach (int mark in marks)
            {
                if (mark < minMarks)
                {
                    minMarks = mark;
                }
            }

            int maxMarks = marks[0];
            foreach (int mark in marks)
            {
                if (mark > maxMarks)
                {
                    maxMarks = mark;
                }
            }

            // Bubble Sort - For Sorting
            int[] ascendingMarks = (int[])marks.Clone();
            for (int i = 0; i < ascendingMarks.Length - 1; i++)
            {
                for (int j = 0; j < ascendingMarks.Length - 1 - i; j++)
                {
                    if (ascendingMarks[j] > ascendingMarks[j + 1])
                    {
                        // Swap
                        int temp = ascendingMarks[j];
                        ascendingMarks[j] = ascendingMarks[j + 1];
                        ascendingMarks[j + 1] = temp;
                    }
                }
            }


            // Bubble Sort - For Sorting
            int[] descendingMarks = (int[])marks.Clone();
            for (int i = 0; i < descendingMarks.Length - 1; i++)
            {
                for (int j = 0; j < descendingMarks.Length - 1 - i; j++)
                {
                    if (descendingMarks[j] < descendingMarks[j + 1])
                    {
                        // Swap
                        int temp = descendingMarks[j];
                        descendingMarks[j] = descendingMarks[j + 1];
                        descendingMarks[j + 1] = temp;


                    }
                }
            }

            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Minimum Marks: " + minMarks);
            Console.WriteLine("Maximum Marks: " + maxMarks);
            Console.WriteLine("Marks in Ascending Order: " + string.Join(", ", ascendingMarks));
            Console.WriteLine("Marks in Descending Order: " + string.Join(", ", descendingMarks));

            Console.ReadKey();
        }
    }
}

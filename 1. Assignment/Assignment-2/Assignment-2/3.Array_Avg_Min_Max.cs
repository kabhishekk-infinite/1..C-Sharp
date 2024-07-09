using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array_Avg_Min_Max
    {
        static void Main(string[] args)
        {
            //My Array
            int[] numbers = { 7, 12, 5, 9, 3, 15 };

            //Avg
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Length;

            //Min
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            //Max
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));
            Console.WriteLine("Average Value: " + average);
            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);

            Console.ReadKey();
        }
    }
}

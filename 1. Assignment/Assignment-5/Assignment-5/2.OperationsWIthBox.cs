using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    // Define the Box class
    class Box
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Constructor
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        // Method to add two Box objects and store in a third Box
        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }

        // Method to display box dimensions
        public void Display()
        {
            Console.WriteLine("Length: {0}, Breadth: {1}", Length, Breadth);
        }
    }

    // Test class to execute the above
    class OperationsWIthBox_Test
    {
        static void Main()
        {
            // Create two Box objects
            Box box1 = new Box(5.5, 4.0);
            Box box2 = new Box(3.0, 2.5);

            // Add two Box objects and store in a third Box
            Box box3 = Box.AddBoxes(box1, box2);

            // Display the dimensions of all three boxes
            Console.WriteLine("Box 1:");
            box1.Display();
            Console.WriteLine("");

            Console.WriteLine("Box 2:");
            box2.Display();
            Console.WriteLine("");

            Console.WriteLine("Box 3 (Sum of Box 1 and Box 2):");
            box3.Display();


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

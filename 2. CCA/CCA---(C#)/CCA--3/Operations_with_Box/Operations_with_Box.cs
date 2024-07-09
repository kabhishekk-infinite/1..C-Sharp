using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_with_Box
{
    class Box                                           //Class name Box.
    {
        //Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        //Constructor
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        //Method - Add Two Box objects & Store the Result in a Third Box object
        public static Box AddBoxes(Box box1, Box box2)                  //Add Boxes.
        {
            double sumLength = box1.Length + box2.Length;               //Sum of Length.
            double sumBreadth = box1.Breadth + box2.Breadth;            //Sum of Breadth.

            return new Box(sumLength, sumBreadth);                      //Returns Value.
        }

        // Method Display - Details of a Box object
        public void DisplayBoxDetails()
        {
            Console.WriteLine("");
            Console.WriteLine($" Box Details : ");
            Console.WriteLine($"   Length : {Length}");
            Console.WriteLine($"   Breadth : {Breadth}");
            Console.WriteLine();
        }
    }

    class Test                                              //Main Class name Test
    {
        static void Main()
        {
            //Create two Box objects
            Box box1 = new Box(5.5, 3.5);
            Box box2 = new Box(2.0, 4.5);

            //Add Two Box objects & Store Result
            Box box3 = Box.AddBoxes(box1, box2);

            //Display Third Box object
            Console.WriteLine("");
            Console.WriteLine("Details of the Third Box (result of addition):");
            box3.DisplayBoxDetails();

            Console.WriteLine("");
            Console.WriteLine("~ ~ ~ Press Any Key To Exit ~ ~ ~");
            Console.ReadLine();

        }
    }
}

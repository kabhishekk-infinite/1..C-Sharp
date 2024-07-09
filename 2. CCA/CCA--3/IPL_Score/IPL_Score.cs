using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Score
{
    class Cricket               //Class with name Cricket.
    {
        //Input from User
        public void PointsCalculation(int no_of_matches)                //Function name PointsCalculation.  
        {
            int[] scores = new int[no_of_matches];                      //No of match as inut from user.
            int sum = 0;                                                //Total Score.


            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of match by Team {i + 1}: ");      //Input scores from the user.
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];                                               //Total Score.
            }

            
            double average = (double)sum / no_of_matches;                       //Calculate Average.

            // Display Sum and Average.
            Console.WriteLine("");
            Console.WriteLine($"Total Numbers of Points Scored in IPL : {sum}");
            Console.WriteLine($"Average Numbers of Points Scored in IPL: {average:F2}");
        }
    }

    class Program                                                               //Main CLass Program.
    {
        static void Main()
        {
            //Input from User.
            Console.Write("Enter The Number of Matches Played in IPL : ");
            int matches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Cricket cricket = new Cricket();
            cricket.PointsCalculation(matches);

            Console.WriteLine("");
            Console.WriteLine("~ ~ ~ Press Any Key to Exit ~ ~ ~");
            Console.ReadLine(); 
        }
    }
}
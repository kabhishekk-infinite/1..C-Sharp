using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelConcessionLibrary
{
    public class ConcessionCalculator
    {
        private const decimal TotalFare = 500m;

        public string CalculateConcession(int age)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                decimal concessionFare = TotalFare * 0.70m; // 30% concession
                return $"Senior Citizen - Calculated Fare: {concessionFare}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare}";
            }
        }
    }
}

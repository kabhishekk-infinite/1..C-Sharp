using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class RegularBike : IBike
    {
        public string GetBikeDetails()
        {
            return "This is a Regular Bike.";
        }
    }

}

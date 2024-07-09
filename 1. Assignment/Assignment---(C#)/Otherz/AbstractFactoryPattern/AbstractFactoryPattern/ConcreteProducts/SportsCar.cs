using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SportsCar : ICar
    {
        public string GetCarDetails()
        {
            return "This is a Sports Car.";
        }
    }

}

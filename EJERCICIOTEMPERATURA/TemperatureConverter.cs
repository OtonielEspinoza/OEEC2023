using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEEC.Temperatura
{
   public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius){
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;

        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;

        }
        
    }
}

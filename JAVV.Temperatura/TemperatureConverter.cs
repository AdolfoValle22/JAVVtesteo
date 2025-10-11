using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAVV.Temperatura
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            // Implementa la conversión de Celsius a Fahrenheit
            // Fórmula: F = C * (9/5) + 32
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Implementa la conversión de Fahrenheit a Celsius
            // Fórmula: C = (F - 32) * (5/9)
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
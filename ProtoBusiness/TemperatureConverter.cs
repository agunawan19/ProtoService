using System;
using ProtoBusiness;

namespace ProtoBusiness
{
    public class TemperatureConverter
    {
        private byte DecimalDigit { get; } = 7;

        public double ConvertFahrenheitToCelcius(double fahrenheit)
        {
            double celcius = (fahrenheit - 32) * 5 / 9;

            return Math.Round(celcius, DecimalDigit);
        }

        public double ConvertCelciusToFahrenheit(double celcius)
        {
            double fahrenheit = celcius * 9 / 5 + 32;

            return Math.Round(fahrenheit, DecimalDigit);
        }
    }
}
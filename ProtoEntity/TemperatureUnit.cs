using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoEntity
{
    public enum Unit
    {
        Celcius,
        Fahrenheit
    }

    public class TemperatureUnit : ITemperatureUnit
    {
        public double TemperatureValue { get; set; }
        public string UnitLongName { get; set; }
        public string UnitShortName { get; set; }
    }
}
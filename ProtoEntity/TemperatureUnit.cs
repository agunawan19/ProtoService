using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoEntity
{
    [Serializable]
    public enum Unit
    {
        Celcius,
        Fahrenheit
    }

    public class TemperatureUnit : IUnit
    {
        public double Value { get; set; }
        public string UnitShortName { get; set; }
        public Unit Unit { get; set; }
    }
}
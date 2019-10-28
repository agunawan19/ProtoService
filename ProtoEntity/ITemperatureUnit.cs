namespace ProtoEntity
{
    public interface ITemperatureUnit
    {
        double TemperatureValue { get; set; }
        string UnitLongName { get; set; }
        string UnitShortName { get; set; }
    }
}
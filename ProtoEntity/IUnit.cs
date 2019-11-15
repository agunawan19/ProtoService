namespace ProtoEntity
{
    public interface IUnit
    {
        double Value { get; set; }
        string UnitShortName { get; set; }
        Unit Unit { get; set; }
    }
}
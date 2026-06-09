using SpaceObjects.Entities;

namespace SpaceObjects.Factories;

public class StarFactory : CosmoObjectFactory
{
    public override string Type => "star";

    public override string DisplayName => "Star";

    public override CosmoObject Create()
    {
        var baseData = ReadBaseData();

        var temperatureInKelvin = ReadDouble("Temperature in Kelvin: ");
        var color = ReadString("Color: ");

        return new Star(
            baseData.Name,
            baseData.MassInTons,
            baseData.SpeedKmPerSecond,
            baseData.AgeInBillionYears,
            temperatureInKelvin,
            color
        );
    }
}
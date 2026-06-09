using SpaceObjects.Entities;

namespace SpaceObjects.Factories;

public class PlanetFactory : CosmoObjectFactory
{
    public override string Type => "planet";

    public override string DisplayName => "Planet";

    public override CosmoObject Create()
    {
        var baseData = ReadBaseData();

        var hasLife = ReadBool("Has life? (true/false): ");
        var atmosphere = ReadString("Atmosphere: ");
        var radiusInKm = ReadDouble("Radius in km: ");

        return new Planet(
            baseData.Name,
            baseData.MassInTons,
            baseData.SpeedKmPerSecond,
            baseData.AgeInBillionYears,
            hasLife,
            atmosphere,
            radiusInKm
        );
    }
}
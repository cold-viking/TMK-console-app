using SpaceObjects.Entities;

namespace SpaceObjects.Factories;

public class AsteroidFactory : CosmoObjectFactory
{
    public override string Type => "asteroid";

    public override string DisplayName => "Asteroid";

    public override CosmoObject Create()
    {
        var baseData = ReadBaseData();

        var diameterInKm = ReadDouble("Diameter in km: ");
        var material = ReadString("Material: ");

        return new Asteroid(
            baseData.Name,
            baseData.MassInTons,
            baseData.SpeedKmPerSecond,
            baseData.AgeInBillionYears,
            diameterInKm,
            material
        );
    }
}
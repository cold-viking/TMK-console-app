using SpaceObjects.Entities;

namespace SpaceObjects.Factories;

public class BlackHoleFactory : CosmoObjectFactory
{
    public override string Type => "blackHole";

    public override string DisplayName => "Black hole";

    public override CosmoObject Create()
    {
        var baseData = ReadBaseData();

        var eventHorizonRadiusInKm = ReadDouble("Event horizon radius in km: ");
        var gravityPower = ReadDouble("Gravity power: ");

        return new BlackHole(
            baseData.Name,
            baseData.MassInTons,
            baseData.SpeedKmPerSecond,
            baseData.AgeInBillionYears,
            eventHorizonRadiusInKm,
            gravityPower
        );
    }
}
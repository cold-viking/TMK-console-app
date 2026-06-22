namespace SpaceObjects.Entities;

public class BlackHole : CosmoObject
{
    
    public BlackHole(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears,
        double eventHorizonRadiusInKm,
        double gravityPower
    ) : base(name, massInTons, speedKmPerSecond, ageInBillionYears)
    {
        EventHorizonRadiusInKm = eventHorizonRadiusInKm;
        GravityPower = gravityPower;
    }
    public override string Type {get; set; } = "blackHole";
    public double EventHorizonRadiusInKm { get; set; }

    public double GravityPower { get; set; }
    
}
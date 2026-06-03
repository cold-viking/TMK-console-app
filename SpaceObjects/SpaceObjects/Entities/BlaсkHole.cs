namespace SpaceProj.Entities;

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
    public override string Type => "blackHole";
    public double EventHorizonRadiusInKm { get; set; }

    public double GravityPower { get; set; }



    public override string GetInfo()
    {
        return $"It is info about BLACK HOLE\n" +
               $"Name: {Name}, " +
               $"Mass in tons: {MassInTons}, " +
               $"Speed km/s: {SpeedKmPerSecond}, " +
               $"Age in billion years: {AgeInBillionYears}, " +
               $"Event horizon radius in km: {EventHorizonRadiusInKm}, " +
               $"Gravity power: {GravityPower}";
    }
}
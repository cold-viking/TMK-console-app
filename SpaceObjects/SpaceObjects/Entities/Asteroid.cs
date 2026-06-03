namespace SpaceProj.Entities;

public class Asteroid : CosmoObject
{
    
    public Asteroid(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears,
        double diameterInKm,
        string material
    ) : base(name, massInTons, speedKmPerSecond, ageInBillionYears)
    {
        DiameterInKm = diameterInKm;
        Material = material;
    }
    
    public override string Type => "asteroid";
    public double DiameterInKm { get; set; }

    public string Material { get; set; }



    public override string GetInfo()
    {
        return $"It is info about ASTEROID\n" +
               $"Name: {Name}, " +
               $"Mass in tons: {MassInTons}, " +
               $"Speed km/s: {SpeedKmPerSecond}, " +
               $"Age in billion years: {AgeInBillionYears}, " +
               $"Diameter in km: {DiameterInKm}, " +
               $"Material: {Material}";
    }
}
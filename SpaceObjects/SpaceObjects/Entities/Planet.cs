namespace SpaceProj.Entities;

public class Planet : CosmoObject
{
    public Planet(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears,
        bool hasLife,
        string atmosphere,
        double radiusInKm
    ) : base(name, massInTons, speedKmPerSecond, ageInBillionYears)
    {
        HasLife = hasLife;
        Atmosphere = atmosphere;
        RadiusInKm = radiusInKm;
    }
    
    public override string Type => "planet";
    
    public bool HasLife { get; set; }

    public string Atmosphere { get; set; }

    public double RadiusInKm { get; set; }



    public override string GetInfo()
    {
        return $"It is info about PLANET\n" +
               $"Name: {Name}, " +
               $"Mass in tons: {MassInTons}, " +
               $"Speed km/s: {SpeedKmPerSecond}, " +
               $"Age in billion years: {AgeInBillionYears}, " +
               $"Has life: {HasLife}, " +
               $"Atmosphere: {Atmosphere}, " +
               $"Radius in km: {RadiusInKm}";
    }
}
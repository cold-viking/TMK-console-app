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
    
}
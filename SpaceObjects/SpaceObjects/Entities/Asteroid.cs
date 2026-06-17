namespace SpaceObjects.Entities;

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

    
}
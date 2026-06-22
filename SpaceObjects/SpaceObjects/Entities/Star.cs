namespace SpaceObjects.Entities;

public class Star : CosmoObject
{
    public Star(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears,
        double temperatureInKelvin,
        string color
    ) : base(name, massInTons, speedKmPerSecond, ageInBillionYears)
    {
        TemperatureInKelvin = temperatureInKelvin;
        Color = color;
    }
    
    public override string Type {get; set; } = "star";
    public double TemperatureInKelvin { get; set; }

    public string Color { get; set; }
    
}
namespace SpaceProj.Entities;

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
    
    public override string Type => "star";
    public double TemperatureInKelvin { get; set; }

    public string Color { get; set; }



    public override string GetInfo()
    {
        return $"It is info about STAR\n" +
               $"Name: {Name}, " +
               $"Mass in tons: {MassInTons}, " +
               $"Speed km/s: {SpeedKmPerSecond}, " +
               $"Age in billion years: {AgeInBillionYears}, " +
               $"Temperature in Kelvin: {TemperatureInKelvin}, " +
               $"Color: {Color}";
    }
}
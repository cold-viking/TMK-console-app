namespace SpaceObjects.Entities;

public abstract class CosmoObject : ITypeDiscriminator
{
    
    protected CosmoObject(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears
    )
    {
        Name = name;
        MassInTons = massInTons;
        SpeedKmPerSecond = speedKmPerSecond;
        AgeInBillionYears = ageInBillionYears;
    }
    
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public double MassInTons { get; set; }

    public double SpeedKmPerSecond { get; set; }

    public double AgeInBillionYears { get; set; }
    
    public abstract string Type { get; }
    
}
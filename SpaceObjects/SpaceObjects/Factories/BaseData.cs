namespace SpaceObjects.Factories;

public class BaseData
{
    public BaseData(
        string name,
        double massInTons,
        double speedKmPerSecond,
        double ageInBillionYears)
    {
        Name = name;
        MassInTons = massInTons;
        SpeedKmPerSecond = speedKmPerSecond;
        AgeInBillionYears = ageInBillionYears;
    }

    public string Name { get; }

    public double MassInTons { get; }

    public double SpeedKmPerSecond { get; }

    public double AgeInBillionYears { get; }
}
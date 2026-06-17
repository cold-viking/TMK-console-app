using SpaceObjects.Entities;

namespace SpaceObjects.Factories;

public abstract class CosmoObjectFactory
{
    public abstract string Type { get; }

    public abstract string DisplayName { get; }

    public abstract CosmoObject Create();

    protected BaseData ReadBaseData()
    {
        string name = ReadString("Name: ");
        double massInTons = ReadDouble("Mass in tons: ");
        double speedKmPerSecond = ReadDouble("Speed km/s: ");
        double ageInBillionYears = ReadDouble("Age in billion years: ");

        return new BaseData(
            name,
            massInTons,
            speedKmPerSecond,
            ageInBillionYears
        );
    }

    protected string ReadString(string message)
    {
        Console.Write(message);

        return Console.ReadLine() ?? string.Empty;
    }

    protected double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out var value))
            {
                return value;
            }

            Console.WriteLine("Incorrect number. Try again");
        }
    }

    protected bool ReadBool(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (bool.TryParse(Console.ReadLine(), out var value))
            {
                return value;
            }

            Console.WriteLine("Enter true or false");
        }
    }
}
using SpaceProj.Entities;

namespace SpaceProj.Services.Printers;

public abstract class DefaultPrinter
{
    public abstract void Print(CosmoObject cosmoObject);

    protected void PrintBaseInfo(CosmoObject cosmoObject)
    {
        Console.WriteLine($"Id: {cosmoObject.Id}");
        Console.WriteLine($"Name: {cosmoObject.Name}");
        Console.WriteLine($"Mass in tons: {cosmoObject.MassInTons}");
        Console.WriteLine($"Speed km/s: {cosmoObject.SpeedKmPerSecond}");
        Console.WriteLine($"Age in billion years: {cosmoObject.AgeInBillionYears}");
    }
}
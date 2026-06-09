using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class StarPrinter : DefaultPrinter
{
    public override void Print(CosmoObject cosmoObject)
    {
        var star = (Star)cosmoObject;

        Console.WriteLine("STAR");
        PrintBaseInfo(star);
        Console.WriteLine($"Temperature in Kelvin: {star.TemperatureInKelvin}");
        Console.WriteLine($"Color: {star.Color}");
        Console.WriteLine();
    }
}
using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class StarPrinter : DefaultPrinter
{
    public override bool CanPrint(CosmoObject cosmoObject)
    {
        return cosmoObject is Star;
    }

    public override void Print(CosmoObject cosmoObject)
    {
        if (cosmoObject is not Star star)
        {
            Console.WriteLine("Incorrect object type for StarPrinter.");
            return;
        }

        Console.WriteLine("STAR");
        PrintBaseInfo(star);
        Console.WriteLine($"Temperature in Kelvin: {star.TemperatureInKelvin}");
        Console.WriteLine($"Color: {star.Color}");
        Console.WriteLine();
    }
}
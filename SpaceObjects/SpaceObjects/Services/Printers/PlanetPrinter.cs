using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class PlanetPrinter : DefaultPrinter
{
    public override bool CanPrint(CosmoObject cosmoObject)
    {
        return cosmoObject is Planet;
    }

    public override void Print(CosmoObject cosmoObject)
    {
        if (cosmoObject is not Planet planet)
        {
            Console.WriteLine("Incorrect object type for PlanetPrinter");
            return;
        }

        Console.WriteLine("PLANET");
        PrintBaseInfo(planet);
        Console.WriteLine($"Has life: {planet.HasLife}");
        Console.WriteLine($"Atmosphere: {planet.Atmosphere}");
        Console.WriteLine($"Radius in km: {planet.RadiusInKm}");
        Console.WriteLine();
    }
}
using SpaceProj.Entities;

namespace SpaceProj.Services.Printers;

public class PlanetPrinter : DefaultPrinter
{
    public override void Print(CosmoObject cosmoObject)
    {
        var planet = (Planet)cosmoObject;

        Console.WriteLine("PLANET");
        PrintBaseInfo(planet);
        Console.WriteLine($"Has life: {planet.HasLife}");
        Console.WriteLine($"Atmosphere: {planet.Atmosphere}");
        Console.WriteLine($"Radius in km: {planet.RadiusInKm}");
        Console.WriteLine();
    }
}
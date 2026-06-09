using SpaceProj.Entities;

namespace SpaceProj.Services.Printers;

public class AsteroidPrinter : DefaultPrinter
{
    public override void Print(CosmoObject cosmoObject)
    {
        var asteroid = (Asteroid)cosmoObject;

        Console.WriteLine("ASTEROID");
        PrintBaseInfo(asteroid);
        Console.WriteLine($"Diameter in km: {asteroid.DiameterInKm}");
        Console.WriteLine($"Material: {asteroid.Material}");
        Console.WriteLine();
    }
}
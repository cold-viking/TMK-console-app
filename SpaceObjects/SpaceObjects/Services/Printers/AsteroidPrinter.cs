using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class AsteroidPrinter : DefaultPrinter
{
    public override bool CanPrint(CosmoObject cosmoObject)
    {
        return cosmoObject is Asteroid;
    }

    public override void Print(CosmoObject cosmoObject)
    {
        if (cosmoObject is not Asteroid asteroid)
        {
            Console.WriteLine("Incorrect object type for AsteroidPrinter.");
            return;
        }

        Console.WriteLine("ASTEROID");
        PrintBaseInfo(asteroid);
        Console.WriteLine($"Diameter in km: {asteroid.DiameterInKm}");
        Console.WriteLine($"Material: {asteroid.Material}");
        Console.WriteLine();
    }
}
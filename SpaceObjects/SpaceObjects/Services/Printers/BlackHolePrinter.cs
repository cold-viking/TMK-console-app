using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class BlackHolePrinter : DefaultPrinter
{
    public override bool CanPrint(CosmoObject cosmoObject)
    {
        return cosmoObject is BlackHole;
    }

    public override void Print(CosmoObject cosmoObject)
    {
        if (cosmoObject is not BlackHole blackHole)
        {
            Console.WriteLine("Incorrect object type for BlackHolePrinter");
            return;
        }

        Console.WriteLine("BLACK HOLE");
        PrintBaseInfo(blackHole);
        Console.WriteLine($"Event horizon radius in km: {blackHole.EventHorizonRadiusInKm}");
        Console.WriteLine($"Gravity power: {blackHole.GravityPower}");
        Console.WriteLine();
    }
}
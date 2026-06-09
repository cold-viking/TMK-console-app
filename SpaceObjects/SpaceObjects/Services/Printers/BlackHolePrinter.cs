using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class BlackHolePrinter : DefaultPrinter
{
    public override void Print(CosmoObject cosmoObject)
    {
        var blackHole = (BlackHole)cosmoObject;

        Console.WriteLine("BLACK HOLE");
        PrintBaseInfo(blackHole);
        Console.WriteLine($"Event horizon radius in km: {blackHole.EventHorizonRadiusInKm}");
        Console.WriteLine($"Gravity power: {blackHole.GravityPower}");
        Console.WriteLine();
    }
}
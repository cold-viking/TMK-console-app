using SpaceProj.Entities;

namespace SpaceProj.Services.Printers;

public class BlackHolePrinter : DefaultPrinter
{
    public override void Print(CosmoObject cosmoObject)
    {
        BlackHole blackHole = (BlackHole)cosmoObject;

        Console.WriteLine("BLACK HOLE");
        PrintBaseInfo(blackHole);
        Console.WriteLine($"Event horizon radius in km: {blackHole.EventHorizonRadiusInKm}");
        Console.WriteLine($"Gravity power: {blackHole.GravityPower}");
        Console.WriteLine();
    }
}
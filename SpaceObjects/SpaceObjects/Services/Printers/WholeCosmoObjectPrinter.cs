using SpaceObjects.Entities;

namespace SpaceObjects.Services.Printers;

public class CosmoObjectPrinter
{
    private readonly List<DefaultPrinter> _printers;

    public CosmoObjectPrinter()
    {
        _printers = new List<DefaultPrinter>
        {
            new PlanetPrinter(),
            new StarPrinter(),
            new AsteroidPrinter(),
            new BlackHolePrinter()
        };
    }

    public void Print(CosmoObject cosmoObject)
    {
        var printer = _printers
            .FirstOrDefault(printer => printer.CanPrint(cosmoObject));

        if (printer is null)
        {
            Console.WriteLine("Printer was not found");
            return;
        }

        printer.Print(cosmoObject);
    }

    public void PrintMany(IEnumerable<CosmoObject> cosmoObjects)
    {
        foreach (var cosmoObject in cosmoObjects)
        {
            Print(cosmoObject);
        }
    }
}
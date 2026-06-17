using SpaceObjects.Repository;
using SpaceObjects.Services.Printers;

namespace SpaceObjects.Commands;

public class DisplayAll : ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly CosmoObjectPrinter _printer;

    public DisplayAll(CosmoObjectRepository repository)
    {
        _repository = repository;
        _printer = new CosmoObjectPrinter();
    }

    public string Name => "Display all objects";

    public void Execute()
    {
        var cosmoObjects = _repository.GetAll();

        if (cosmoObjects.Count == 0)
        {
            Console.WriteLine("Objects were not found");
            return;
        }

        _printer.PrintMany(cosmoObjects);
    }
}
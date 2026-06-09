using SpaceObjects.Factories;
using SpaceObjects.Repository;
using SpaceObjects.Services.Printers;

namespace SpaceObjects.Commands;

public class DisplayByType : ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly CosmoObjectPrinter _printer;
    private readonly CosmoObjectFactorySelector _factorySelector;

    public DisplayByType(
        CosmoObjectRepository repository,
        CosmoObjectPrinter printer,
        CosmoObjectFactorySelector factorySelector)
    {
        _repository = repository;
        _printer = printer;
        _factorySelector = factorySelector;
    }

    public string Name => "Display objects by type";

    public void Execute()
    {
        var type = _factorySelector.SelectType();

        var cosmoObjects = _repository.GetByType(type);

        if (cosmoObjects.Count == 0)
        {
            Console.WriteLine("Objects were not found");
            return;
        }

        _printer.PrintMany(cosmoObjects);
    }
}
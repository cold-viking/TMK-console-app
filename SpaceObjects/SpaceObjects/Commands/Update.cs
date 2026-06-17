using SpaceObjects.Entities;
using SpaceObjects.Factories;
using SpaceObjects.Repository;
using SpaceObjects.Services.Printers;

namespace SpaceObjects.Commands;

public class Update : ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly CosmoObjectPrinter _printer;
    private readonly CosmoObjectFactorySelector _factorySelector;

    public Update(
        CosmoObjectRepository repository,
        CosmoObjectPrinter printer,
        CosmoObjectFactorySelector factorySelector)
    {
        _repository = repository;
        _printer = printer;
        _factorySelector = factorySelector;
    }

    public string Name => "Update object";

    public void Execute()
    {
        var cosmoObjects = _repository.GetAll();

        if (cosmoObjects.Count == 0)
        {
            Console.WriteLine("Objects were not found");
            return;
        }

        _printer.PrintMany(cosmoObjects);

        Console.Write("Enter object Id: ");
        var input = Console.ReadLine();

        if (!Guid.TryParse(input, out var id))
        {
            Console.WriteLine("Incorrect Id");
            return;
        }

        var oldObject = _repository.GetById(id);

        if (oldObject is null)
        {
            Console.WriteLine("Object was not found");
            return;
        }

        Console.WriteLine($"Updating object with type: {oldObject.Type}");
        Console.WriteLine("Enter new values: ");

        var factory = _factorySelector.GetFactoryByType(oldObject.Type);

        var newObject = factory.Create();

        var updated = _repository.Update(id, newObject);

        Console.WriteLine(updated
            ? "Object was updated and saved to file"
            : "Object was not updated");
    }
}
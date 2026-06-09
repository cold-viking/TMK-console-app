using SpaceObjects.Repository;
using SpaceObjects.Services.Printers;

namespace SpaceObjects.Commands;

public class Delete : ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly CosmoObjectPrinter _printer;

    public Delete(
        CosmoObjectRepository repository,
        CosmoObjectPrinter printer)
    {
        _repository = repository;
        _printer = printer;
    }

    public string Name => "Delete object";

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
        string? input = Console.ReadLine();

        if (!Guid.TryParse(input, out var id))
        {
            Console.WriteLine("Incorrect Id");
            return;
        }

        bool deleted = _repository.Delete(id);

        Console.WriteLine(deleted
            ? "Object was deleted"
            : "Object was not found");
    }
}
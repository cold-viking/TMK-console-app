using SpaceObjects.Entities;
using SpaceObjects.Factories;
using SpaceObjects.Services;

namespace SpaceObjects.Commands;

public class AddToDbCommand : ICommand
{
    private readonly CosmoDbService _dbService;
    private readonly CosmoObjectFactorySelector _factory;

    public AddToDbCommand(CosmoDbService dbService, CosmoObjectFactorySelector factory)
    {
        _dbService = dbService;
        _factory = factory;
    }

    public string Name => "Add to DB";

    public void Execute()
    {
        Console.WriteLine("Enter type:");
        var type = Console.ReadLine();

        var factory = _factory.GetFactoryByType(type);
        var obj = factory.Create();

        _dbService.Add(obj);

        Console.WriteLine("Saved to DB");
    }
}
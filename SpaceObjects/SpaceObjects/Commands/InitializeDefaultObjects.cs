using SpaceObjects.Entities;
using SpaceObjects.Repository;
using SpaceObjects.Services.Initializers;

namespace SpaceObjects.Commands;

public class InitializeDefaultObjects : ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly DefaultInitializer _initializer;

    public InitializeDefaultObjects(CosmoObjectRepository repository)
    {
        _repository = repository;
        _initializer = new DefaultInitializer();
    }

    public string Name => "Initialize default objects";

    public void Execute()
    {
        var defaultObjects = _initializer.Create();

        _repository.RewriteAll(defaultObjects);

        Console.WriteLine("Default objects were initialized and saved to file");
    }
}
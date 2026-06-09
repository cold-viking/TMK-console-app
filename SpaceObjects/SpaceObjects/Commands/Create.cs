using SpaceObjects.Entities;
using SpaceObjects.Factories;
using SpaceObjects.Repository;

namespace SpaceObjects.Commands;

public class Create: ICommand
{
    private readonly CosmoObjectRepository _repository;
    private readonly CosmoObjectFactorySelector _factorySelector;

    public Create(
        CosmoObjectRepository repository,
        CosmoObjectFactorySelector factorySelector)
    {
        _repository = repository;
        _factorySelector = factorySelector;
    }

    public string Name => "Create object";

    public void Execute()
    {
        var factory = _factorySelector.SelectFactory();

        var cosmoObject = factory.Create();

        _repository.Add(cosmoObject);

        Console.WriteLine("Object was created and saved to file");
    }
}
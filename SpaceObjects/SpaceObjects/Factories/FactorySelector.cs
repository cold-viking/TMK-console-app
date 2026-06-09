namespace SpaceObjects.Factories;

public class CosmoObjectFactorySelector
{
    private readonly List<CosmoObjectFactory> _factories;

    public CosmoObjectFactorySelector()
    {
        _factories = new List<CosmoObjectFactory>
        {
            new PlanetFactory(),
            new StarFactory(),
            new AsteroidFactory(),
            new BlackHoleFactory()
        };
    }

    public CosmoObjectFactory SelectFactory()
    {
        while (true)
        {
            Console.WriteLine("Choose object type: ");

            for (var i = 0; i < _factories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_factories[i].DisplayName}");
            }

            Console.Write("Your choice: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number) &&
                number >= 1 &&
                number <= _factories.Count)
            {
                return _factories[number - 1];
            }

            Console.WriteLine("Incorrect object type");
            Console.WriteLine();
        }
    }

    public CosmoObjectFactory GetFactoryByType(string type)
    {
        var factory = _factories
            .FirstOrDefault(factory => factory.Type == type);

        if (factory is null)
        {
            throw new InvalidOperationException("Factory was not found");
        }

        return factory;
    }

    public string SelectType()
    {
        return SelectFactory().Type;
    }
}
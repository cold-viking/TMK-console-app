using SpaceProj.Entities;

namespace SpaceProj.Services.Initializers;

public class DefaultInitializer
{
    private readonly List<CosmoObjectInitializer> initializers = new()
    {
        new StarInitializer(),
        new PlanetInitializer(),
        new BlackHoleInitializer(),
        new AsteroidInitializer()
    };

    public List<CosmoObject> Create()
    {
        return initializers
            .Select(initializer => initializer.Create())
            .ToList();
    }
}
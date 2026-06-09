using SpaceObjects.Entities;
using SpaceObjects.Services.Initializers;
using SpaceObjects.Entities;

namespace SpaceObjects.Services.Initializers;

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
using SpaceObjects.Entities;

namespace SpaceObjects.Services.Initializers;

public abstract class CosmoObjectInitializer
{
    public abstract CosmoObject Create();
}
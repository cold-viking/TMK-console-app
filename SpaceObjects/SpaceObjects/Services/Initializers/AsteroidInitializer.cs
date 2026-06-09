using SpaceObjects.Entities;

namespace SpaceObjects.Services.Initializers;

public class AsteroidInitializer : CosmoObjectInitializer
{
    public override CosmoObject Create()
    {
        return new Asteroid(
            "Ceres",
            939,
            17.9,
            4.5,
            939.4,
            "Rock and ice"
        );
    }
}
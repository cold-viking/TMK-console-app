using SpaceObjects.Services.Initializers;
using SpaceObjects.Entities;

namespace SpaceObjects.Services.Initializers;

public class StarInitializer : CosmoObjectInitializer
{
    public override CosmoObject Create()
    {
        return new Star(
            "Sun",
            9999,
            220,
            4.5,
            5800,
            "Yellow"
        );
    }
}
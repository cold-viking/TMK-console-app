using SpaceObjects.Entities;

namespace SpaceObjects.Services.Initializers;

public class BlackHoleInitializer : CosmoObjectInitializer
{
    public override CosmoObject Create()
    {
        return new BlackHole(
            "Sagittarius A*",
            4300000,
            0,
            13.6,
            12000000,
            999999
        );
    }
}
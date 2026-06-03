using SpaceProj.Entities;

namespace SpaceProj.Services.Initializers;

public class PlanetInitializer : CosmoObjectInitializer
{
    public override CosmoObject Create()
    {
        return new Planet(
            "Earth",
            5972,
            29.78,
            4.5,
            true,
            "Nitrogen-oxygen",
            6371
        );
    }
}
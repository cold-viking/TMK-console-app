using SpaceObjects.Entities;
using SpaceObjects.Services;
using SpaceObjects.Tests.Infrastructure;
using Xunit;

namespace SpaceObjects.Tests.Tests.Db;

public class CosmoDbServiceTests
{
    [Fact]
    public void Add_Should_Save_Object_To_Postgres()
    {
        var db = TestDbFactory.Create();
        var service = new CosmoDbService(db);

        var planet = new Planet(
            "TestPlanet",
            1,
            1,
            1,
            true,
            "rock",
            1
        );
        
        service.Add(planet);

        var result = service.GetAll();
        Assert.Contains(result, x => x.Name == "TestPlanet");
    }
    
    [Fact]
    public void GetAll_Should_Not_Be_Null()
    {
        var db = TestDbFactory.Create();
        var service = new CosmoDbService(db);

        var result = service.GetAll();

        Assert.NotNull(result);
    }
}
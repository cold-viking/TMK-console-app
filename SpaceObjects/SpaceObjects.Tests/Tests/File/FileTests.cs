using SpaceObjects.Entities;
using SpaceObjects.Services;
using Xunit;

namespace SpaceObjects.Tests.Tests.File;

public class FileTests
{
    [Fact]
    public void Writer_And_Reader_Should_Work()
    {
        const string file = "test.json";

        var planet = new Planet(
            "Earth",
            5972,
            29.78,
            4.5,
            true,
            "Nitrogen-oxygen",
            6371
        );

        Writer.Save(planet, file);

        var loaded = Reader.Load<Planet>(file);

        Assert.Equal("Earth", loaded.Name);
    }
}
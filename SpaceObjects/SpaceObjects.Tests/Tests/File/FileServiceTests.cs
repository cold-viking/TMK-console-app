using SpaceObjects.Entities;
using SpaceObjects.Repository;
using SpaceObjects.Services;
using SpaceObjects.Tests.Infrastructure;
using Xunit;

namespace SpaceObjects.Tests.Tests.File;

public class FileServiceTests
{
    [Fact]
    public void Save_Should_Write_And_Load_Data()
    {
        const string file = "test_cosmo.json";
        var repo = new CosmoObjectRepository(file);
        var service = new FileService(repo);

        var objects = new List<CosmoObject>
        {
            new Planet { Name = "Earth" }
        };
        
        service.Save(objects);
        var loaded = service.Load();
        
        Assert.Contains(loaded, x => x.Name == "Earth");
    }
    
    [Fact]
    public void Load_Should_Return_Empty_List_If_File_Not_Exists()
    {
        const string file = "not_existing_file.json";
        var repo = new FileCosmoRepository(file);
        var service = new FileService(repo);

        var result = service.Load();

        Assert.NotNull(result);
    }
    
    [Fact]
    public void Service_Should_Save_To_Db()
    {
        var db = TestDbFactory.Create();
        var dbService = new CosmoDbService(db);

        var obj = new Planet { Name = "Mars" };

        dbService.Add(obj);

        var result = dbService.GetAll();

        Assert.Contains(result, x => x.Name == "Mars");
    }
}
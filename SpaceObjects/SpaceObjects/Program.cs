using Microsoft.EntityFrameworkCore;
using SpaceObjects.Commands;
using SpaceObjects.Data;
using SpaceObjects.Entities;
using SpaceObjects.Factories;
using SpaceObjects.Menus;
using SpaceObjects.Repository;
using SpaceObjects.Services;
using SpaceObjects.Services.Initializers;
using SpaceObjects.Services.Printers;

public class Program
{
    public static void Main()
    {
        DotNetEnv.Env.Load();

        var host = Environment.GetEnvironmentVariable("POSTGRES_HOST");
        var port = Environment.GetEnvironmentVariable("POSTGRES_PORT");
        var db_name = Environment.GetEnvironmentVariable("POSTGRES_DB");
        var user = Environment.GetEnvironmentVariable("POSTGRES_USER");
        var password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");

        var connectionString =
            $"Host={host};Port={port};Database={db_name};Username={user};Password={password}";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseNpgsql(connectionString)
            .Options;

        var db = new AppDbContext(options);

        Console.WriteLine(db.Database.CanConnect());
        
        const string fileName = "cosmoObjects.json";

        var initializer = new DefaultInitializer();
        var defaultObjects = initializer.Create();

        FileManager.CreateIfNotExists(fileName, defaultObjects);

        var repository = new CosmoObjectRepository(fileName);
        
        var dbService = new CosmoDbService(db);

        var printer = new CosmoObjectPrinter();
        var factorySelector = new CosmoObjectFactorySelector();
        
        List<ICommand> commands = new()
        {
            new DisplayAll(repository),
            new DisplayByType(repository, printer, factorySelector),
            new Create(repository, factorySelector),
            new Update(repository, printer, factorySelector),
            new Delete(repository, printer),
            new InitializeDefaultObjects(repository),

            new AddToDbCommand(dbService, factorySelector)
        };

        var menu = new ConsoleMenu(commands);
        menu.Run();
    }
}
using SpaceObjects.Commands;
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
        const string fileName = "cosmoObjects.json";

        var initializer = new DefaultInitializer();
        var defaultObjects = initializer.Create();

        FileManager.CreateIfNotExists(fileName, defaultObjects);

        var repository = new CosmoObjectRepository(fileName);
        var printer = new CosmoObjectPrinter();
        var factorySelector = new CosmoObjectFactorySelector();

        List<ICommand> commands = new()
        {
            new DisplayAll(repository),
            new DisplayByType(repository, printer, factorySelector),
            new Create(repository, factorySelector),
            new Update(repository, printer, factorySelector),
            new Delete(repository, printer),
            new InitializeDefaultObjects(repository)
        };

        var menu = new ConsoleMenu(commands);

        menu.Run();
    }
}
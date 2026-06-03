using SpaceProj.Services;
using SpaceProj.Entities;
using SpaceProj.Services;
using SpaceProj.Services.Initializers;


public class Program
{
    public static void Main()
    {

        string fileName = "cosmoObjects.json";

        DefaultInitializer initializer = new DefaultInitializer();

        List<CosmoObject> defaultObjects = initializer.Create();

        FileManager.CreateIfNotExists(fileName, defaultObjects);

        List<CosmoObject> cosmoObjects = Reader.Load<List<CosmoObject>>(fileName);
    }
}
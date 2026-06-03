using System.Text.Json;

namespace SpaceProj.Services;

public static class Writer
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        Converters =
        {
            new CosmoObjectJsonConverter()
        }
    };

    public static void Save<T>(T objectToWrite, string fileName)
    {
        string json = JsonSerializer.Serialize(objectToWrite, Options);

        File.WriteAllText(fileName, json);
    }
}
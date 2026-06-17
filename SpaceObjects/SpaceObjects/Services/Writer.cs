using System.Text.Json;

namespace SpaceObjects.Services;

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
        var json = JsonSerializer.Serialize(objectToWrite, Options);

        File.WriteAllText(fileName, json);
    }
}
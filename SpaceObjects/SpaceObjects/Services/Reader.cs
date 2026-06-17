using System.Text.Json;

namespace SpaceObjects.Services;

public static class Reader
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        Converters =
        {
            new CosmoObjectJsonConverter()
        }
    };

    public static T Load<T>(string fileName)
    {
        var jsonFromFile = File.ReadAllText(fileName);

        var restoredObject = JsonSerializer.Deserialize<T>(jsonFromFile, Options);

        if (restoredObject == null)
        {
            throw new InvalidOperationException("ERROR: Object was not deserialized from json");
        }

        return restoredObject;
    }
}
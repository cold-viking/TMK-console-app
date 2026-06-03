using System.Text.Json;

namespace SpaceProj.Services;

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
        string jsonFromFile = File.ReadAllText(fileName);

        T? restoredObject = JsonSerializer.Deserialize<T>(jsonFromFile, Options);

        if (restoredObject == null)
        {
            throw new InvalidOperationException("ERROR: Object was not deserialized from json");
        }

        return restoredObject;
    }
}
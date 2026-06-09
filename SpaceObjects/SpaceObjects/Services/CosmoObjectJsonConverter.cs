using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceObjects.Entities;

namespace SpaceObjects.Services;

public class CosmoObjectJsonConverter : JsonConverter<CosmoObject>
{
    public override CosmoObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        if (!root.TryGetProperty(nameof(CosmoObject.Type), out var typeElement))
        {
            throw new JsonException();
        }

        var type = typeElement.GetString();

        return type switch
        {
            "star" => Deserialize<Star>(root, options),
            "planet" => Deserialize<Planet>(root, options),
            "asteroid" => Deserialize<Asteroid>(root, options),
            "blackHole" => Deserialize<BlackHole>(root, options),
            _ => throw new JsonException($"Unknown cosmo object type: '{type}'.")
        };
    }

    public override void Write(Utf8JsonWriter writer, CosmoObject value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
    
    private static T Deserialize<T>(JsonElement root, JsonSerializerOptions options) where T : CosmoObject
    {
        var cosmoObject = root.Deserialize<T>(options);

        if (cosmoObject is null)
        {
            throw new JsonException();
        }

        return cosmoObject;
    }
}
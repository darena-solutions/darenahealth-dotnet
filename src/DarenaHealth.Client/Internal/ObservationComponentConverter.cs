using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DarenaHealth.Models.HR;

namespace DarenaHealth.Client.Internal;

/// <inheritdoc />
internal class ObservationComponentConverter : JsonConverter<Observation.IComponent>
{
    /// <inheritdoc />
    public override Observation.IComponent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        if (root.TryGetProperty(nameof(Observation.GenericComponent.Code), out _) || root.TryGetProperty("code", out _))
        {
            return root.Deserialize<Observation.GenericComponent>(options);
        }

        return root.Deserialize<ComponentCodeValue>(options);
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Observation.IComponent value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}

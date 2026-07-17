using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollCalcResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("npd")]
    public required string Npd { get; set; }

    [JsonPropertyName("gpm")]
    public required string Gpm { get; set; }

    [JsonPropertyName("sodraEmployee")]
    public required string SodraEmployee { get; set; }

    [JsonPropertyName("sodraEmployer")]
    public required string SodraEmployer { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

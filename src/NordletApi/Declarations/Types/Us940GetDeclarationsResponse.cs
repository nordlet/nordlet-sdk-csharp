using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record Us940GetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required double Year { get; set; }

    [JsonPropertyName("line1a")]
    public string? Line1A { get; set; }

    [JsonPropertyName("line1b")]
    public required bool Line1B { get; set; }

    [JsonPropertyName("line3")]
    public required string Line3 { get; set; }

    [JsonPropertyName("line4")]
    public required string Line4 { get; set; }

    [JsonPropertyName("line5")]
    public required string Line5 { get; set; }

    [JsonPropertyName("line6")]
    public required string Line6 { get; set; }

    [JsonPropertyName("line7")]
    public required string Line7 { get; set; }

    [JsonPropertyName("line8")]
    public required string Line8 { get; set; }

    [JsonPropertyName("line12")]
    public required string Line12 { get; set; }

    [JsonPropertyName("part5")]
    public Us940GetDeclarationsResponsePart5? Part5 { get; set; }

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

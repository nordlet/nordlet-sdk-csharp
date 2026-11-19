using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsW2ListDeclarationsResponseW3 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("boxC")]
    public required double BoxC { get; set; }

    [JsonPropertyName("boxE")]
    public string? BoxE { get; set; }

    [JsonPropertyName("boxF")]
    public required string BoxF { get; set; }

    [JsonPropertyName("box1")]
    public required string Box1 { get; set; }

    [JsonPropertyName("box2")]
    public required string Box2 { get; set; }

    [JsonPropertyName("box3")]
    public required string Box3 { get; set; }

    [JsonPropertyName("box4")]
    public required string Box4 { get; set; }

    [JsonPropertyName("box5")]
    public required string Box5 { get; set; }

    [JsonPropertyName("box6")]
    public required string Box6 { get; set; }

    [JsonPropertyName("box16")]
    public required string Box16 { get; set; }

    [JsonPropertyName("box17")]
    public required string Box17 { get; set; }

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

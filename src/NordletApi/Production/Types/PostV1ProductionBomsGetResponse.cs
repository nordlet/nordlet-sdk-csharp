using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionBomsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("finishedItemId")]
    public required string FinishedItemId { get; set; }

    [JsonPropertyName("outputQuantity")]
    public required string OutputQuantity { get; set; }

    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1ProductionBomsGetResponseLinesItem> Lines { get; set; } =
        new List<PostV1ProductionBomsGetResponseLinesItem>();

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

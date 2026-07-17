using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesActsCreateResponseLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("unit")]
    public required string Unit { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("unitPriceExclVat")]
    public string? UnitPriceExclVat { get; set; }

    [JsonPropertyName("lineNet")]
    public string? LineNet { get; set; }

    [JsonPropertyName("sortOrder")]
    public required long SortOrder { get; set; }

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

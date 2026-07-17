using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsStockMovementResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("itemName")]
    public required string ItemName { get; set; }

    [JsonPropertyName("openingQty")]
    public required string OpeningQty { get; set; }

    [JsonPropertyName("openingValue")]
    public required string OpeningValue { get; set; }

    [JsonPropertyName("inQty")]
    public required string InQty { get; set; }

    [JsonPropertyName("inValue")]
    public required string InValue { get; set; }

    [JsonPropertyName("outQty")]
    public required string OutQty { get; set; }

    [JsonPropertyName("outValue")]
    public required string OutValue { get; set; }

    [JsonPropertyName("closingQty")]
    public required string ClosingQty { get; set; }

    [JsonPropertyName("closingValue")]
    public required string ClosingValue { get; set; }

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

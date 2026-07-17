using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsWriteOffActsResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("movementId")]
    public required string MovementId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("documentType")]
    public required string DocumentType { get; set; }

    [JsonPropertyName("itemName")]
    public required string ItemName { get; set; }

    [JsonPropertyName("warehouseCode")]
    public required string WarehouseCode { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("totalCost")]
    public required string TotalCost { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

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

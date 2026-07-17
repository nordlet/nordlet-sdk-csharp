using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1EcommerceStockListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("warehouseId")]
    public required string WarehouseId { get; set; }

    [JsonPropertyName("onHand")]
    public required string OnHand { get; set; }

    [JsonPropertyName("reserved")]
    public required string Reserved { get; set; }

    [JsonPropertyName("available")]
    public required string Available { get; set; }

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

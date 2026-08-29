using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesInvoicesMatchResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("orderedQty")]
    public required string OrderedQty { get; set; }

    [JsonPropertyName("receivedQty")]
    public required string ReceivedQty { get; set; }

    [JsonPropertyName("invoicedQty")]
    public required string InvoicedQty { get; set; }

    [JsonPropertyName("orderedUnitPrice")]
    public string? OrderedUnitPrice { get; set; }

    [JsonPropertyName("invoicedUnitPrice")]
    public string? InvoicedUnitPrice { get; set; }

    [JsonPropertyName("priceVariancePercent")]
    public string? PriceVariancePercent { get; set; }

    [JsonPropertyName("status")]
    public required PostV1PurchasesInvoicesMatchResponseRowsItemStatus Status { get; set; }

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

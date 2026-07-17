using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtSaftGenerateResponseCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("accounts")]
    public required long Accounts { get; set; }

    [JsonPropertyName("customers")]
    public required long Customers { get; set; }

    [JsonPropertyName("suppliers")]
    public required long Suppliers { get; set; }

    [JsonPropertyName("glTransactions")]
    public required long GlTransactions { get; set; }

    [JsonPropertyName("salesInvoices")]
    public required long SalesInvoices { get; set; }

    [JsonPropertyName("purchaseInvoices")]
    public required long PurchaseInvoices { get; set; }

    [JsonPropertyName("payments")]
    public required long Payments { get; set; }

    [JsonPropertyName("stockMovements")]
    public required long StockMovements { get; set; }

    [JsonPropertyName("assetTransactions")]
    public required long AssetTransactions { get; set; }

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

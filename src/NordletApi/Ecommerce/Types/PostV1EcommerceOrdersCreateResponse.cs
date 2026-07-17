using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1EcommerceOrdersCreateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("channel")]
    public required string Channel { get; set; }

    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("status")]
    public required PostV1EcommerceOrdersCreateResponseStatus Status { get; set; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; set; }

    [JsonPropertyName("shipToCountryCode")]
    public string? ShipToCountryCode { get; set; }

    [JsonPropertyName("marketplace")]
    public string? Marketplace { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1EcommerceOrdersCreateResponseLinesItem> Lines { get; set; } =
        new List<PostV1EcommerceOrdersCreateResponseLinesItem>();

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

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1EcommerceOrdersCreateRequest
{
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("partner")]
    public PostV1EcommerceOrdersCreateRequestPartner? Partner { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("shipToCountryCode")]
    public string? ShipToCountryCode { get; set; }

    [JsonPropertyName("marketplace")]
    public string? Marketplace { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1EcommerceOrdersCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1EcommerceOrdersCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

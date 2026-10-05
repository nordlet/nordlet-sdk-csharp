using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ActsUpdateSalesRequest
{
    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("type")]
    public ActsUpdateSalesRequestType? Type { get; set; }

    [JsonPropertyName("documentDate")]
    public DateOnly? DocumentDate { get; set; }

    [JsonPropertyName("saleInvoiceId")]
    public string? SaleInvoiceId { get; set; }

    [JsonPropertyName("transferredByName")]
    public string? TransferredByName { get; set; }

    [JsonPropertyName("transferredByTitle")]
    public string? TransferredByTitle { get; set; }

    [JsonPropertyName("acceptedByName")]
    public string? AcceptedByName { get; set; }

    [JsonPropertyName("acceptedByTitle")]
    public string? AcceptedByTitle { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<ActsUpdateSalesRequestLinesItem>? Lines { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

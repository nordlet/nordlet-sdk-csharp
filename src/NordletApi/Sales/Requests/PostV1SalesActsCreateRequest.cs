using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesActsCreateRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public PostV1SalesActsCreateRequestType? Type { get; set; }

    [JsonPropertyName("documentDate")]
    public string? DocumentDate { get; set; }

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
    public IEnumerable<PostV1SalesActsCreateRequestLinesItem>? Lines { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

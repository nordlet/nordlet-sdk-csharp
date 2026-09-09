using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesCreateRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public PostV1SalesInvoicesCreateRequestType? Type { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("issueDate")]
    public string? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("creditedInvoiceId")]
    public string? CreditedInvoiceId { get; set; }

    [JsonPropertyName("vatScheme")]
    public PostV1SalesInvoicesCreateRequestVatScheme? VatScheme { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("deemedSupplier")]
    public bool? DeemedSupplier { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("operationTypeId")]
    public string? OperationTypeId { get; set; }

    [JsonPropertyName("documentSeriesId")]
    public string? DocumentSeriesId { get; set; }

    [JsonPropertyName("seriesLabel")]
    public string? SeriesLabel { get; set; }

    [JsonPropertyName("orderNumber")]
    public string? OrderNumber { get; set; }

    [JsonPropertyName("issuedByName")]
    public string? IssuedByName { get; set; }

    [JsonPropertyName("issuedByTitle")]
    public string? IssuedByTitle { get; set; }

    [JsonPropertyName("receivedByName")]
    public string? ReceivedByName { get; set; }

    [JsonPropertyName("receivedByTitle")]
    public string? ReceivedByTitle { get; set; }

    [JsonPropertyName("discountPercent")]
    public string? DiscountPercent { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1SalesInvoicesCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1SalesInvoicesCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

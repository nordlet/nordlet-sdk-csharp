using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesInvoicesCreateRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public PostV1PurchasesInvoicesCreateRequestType? Type { get; set; }

    [JsonPropertyName("documentNumber")]
    public required string DocumentNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public required string DocumentDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("creditedInvoiceId")]
    public string? CreditedInvoiceId { get; set; }

    [JsonPropertyName("purchaseOrderId")]
    public string? PurchaseOrderId { get; set; }

    [JsonPropertyName("operationTypeId")]
    public string? OperationTypeId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("intrastatTransportMode")]
    public string? IntrastatTransportMode { get; set; }

    [JsonPropertyName("intrastatDeliveryTerms")]
    public string? IntrastatDeliveryTerms { get; set; }

    [JsonPropertyName("intrastatRegion")]
    public string? IntrastatRegion { get; set; }

    [JsonPropertyName("intrastatNatureOfTransaction")]
    public string? IntrastatNatureOfTransaction { get; set; }

    [JsonPropertyName("einvoiceNumber")]
    public string? EinvoiceNumber { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1PurchasesInvoicesCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1PurchasesInvoicesCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

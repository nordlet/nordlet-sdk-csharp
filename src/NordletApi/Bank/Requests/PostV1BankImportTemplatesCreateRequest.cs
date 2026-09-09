using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankImportTemplatesCreateRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required PostV1BankImportTemplatesCreateRequestType Type { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1BankImportTemplatesCreateRequestFieldsItem>? Fields { get; set; }

    [JsonPropertyName("metaFields")]
    public IEnumerable<string>? MetaFields { get; set; }

    [JsonPropertyName("invoiceMetaField")]
    public string? InvoiceMetaField { get; set; }

    [JsonPropertyName("invoiceVatRatePercent")]
    public string? InvoiceVatRatePercent { get; set; }

    [JsonPropertyName("companyMetaField")]
    public string? CompanyMetaField { get; set; }

    [JsonPropertyName("invoiceItemId")]
    public string? InvoiceItemId { get; set; }

    [JsonPropertyName("advanceInvoices")]
    public bool? AdvanceInvoices { get; set; }

    [JsonPropertyName("authorizationOperationTypeId")]
    public string? AuthorizationOperationTypeId { get; set; }

    [JsonPropertyName("payoutOperationTypeId")]
    public string? PayoutOperationTypeId { get; set; }

    [JsonPropertyName("commissionOperationTypeId")]
    public string? CommissionOperationTypeId { get; set; }

    [JsonPropertyName("lenderMetaField")]
    public string? LenderMetaField { get; set; }

    [JsonPropertyName("partialRefundLabel")]
    public string? PartialRefundLabel { get; set; }

    [JsonPropertyName("fullRefundLabel")]
    public string? FullRefundLabel { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

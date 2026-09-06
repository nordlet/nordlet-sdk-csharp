using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankImportTemplatesUpdateRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public PostV1BankImportTemplatesUpdateRequestType? Type { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1BankImportTemplatesUpdateRequestFieldsItem>? Fields { get; set; }

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

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

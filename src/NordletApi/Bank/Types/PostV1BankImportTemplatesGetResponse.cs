using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankImportTemplatesGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required PostV1BankImportTemplatesGetResponseType Type { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1BankImportTemplatesGetResponseFieldsItem> Fields { get; set; } =
        new List<PostV1BankImportTemplatesGetResponseFieldsItem>();

    [JsonPropertyName("metaFields")]
    public IEnumerable<string> MetaFields { get; set; } = new List<string>();

    [JsonPropertyName("invoiceMetaField")]
    public string? InvoiceMetaField { get; set; }

    [JsonPropertyName("invoiceVatRatePercent")]
    public string? InvoiceVatRatePercent { get; set; }

    [JsonPropertyName("companyMetaField")]
    public string? CompanyMetaField { get; set; }

    [JsonPropertyName("invoiceItemId")]
    public string? InvoiceItemId { get; set; }

    [JsonPropertyName("advanceInvoices")]
    public required bool AdvanceInvoices { get; set; }

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

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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

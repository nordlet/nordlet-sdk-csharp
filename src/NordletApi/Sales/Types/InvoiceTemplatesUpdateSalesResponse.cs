using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoiceTemplatesUpdateSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("documentType")]
    public required InvoiceTemplatesUpdateSalesResponseDocumentType DocumentType { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("paymentTermDays")]
    public long? PaymentTermDays { get; set; }

    [JsonPropertyName("vatScheme")]
    public string? VatScheme { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; set; }

    [JsonPropertyName("operationTypeId")]
    public string? OperationTypeId { get; set; }

    [JsonPropertyName("documentSeriesId")]
    public string? DocumentSeriesId { get; set; }

    [JsonPropertyName("discountPercent")]
    public string? DiscountPercent { get; set; }

    [JsonPropertyName("issuedByName")]
    public string? IssuedByName { get; set; }

    [JsonPropertyName("issuedByTitle")]
    public string? IssuedByTitle { get; set; }

    [JsonPropertyName("receivedByName")]
    public string? ReceivedByName { get; set; }

    [JsonPropertyName("receivedByTitle")]
    public string? ReceivedByTitle { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("supplyType")]
    public InvoiceTemplatesUpdateSalesResponseSupplyType? SupplyType { get; set; }

    [JsonPropertyName("seriesLabel")]
    public string? SeriesLabel { get; set; }

    [JsonPropertyName("orderNumber")]
    public string? OrderNumber { get; set; }

    [JsonPropertyName("intrastatTransportMode")]
    public string? IntrastatTransportMode { get; set; }

    [JsonPropertyName("intrastatDeliveryTerms")]
    public string? IntrastatDeliveryTerms { get; set; }

    [JsonPropertyName("intrastatRegion")]
    public string? IntrastatRegion { get; set; }

    [JsonPropertyName("intrastatNatureOfTransaction")]
    public string? IntrastatNatureOfTransaction { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<InvoiceTemplatesUpdateSalesResponseLinesItem> Lines { get; set; } =
        new List<InvoiceTemplatesUpdateSalesResponseLinesItem>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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

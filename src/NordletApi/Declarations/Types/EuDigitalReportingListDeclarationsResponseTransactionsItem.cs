using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuDigitalReportingListDeclarationsResponseTransactionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("direction")]
    public required EuDigitalReportingListDeclarationsResponseTransactionsItemDirection Direction { get; set; }

    [JsonPropertyName("article")]
    public required EuDigitalReportingListDeclarationsResponseTransactionsItemArticle Article { get; set; }

    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    [JsonPropertyName("documentType")]
    public required EuDigitalReportingListDeclarationsResponseTransactionsItemDocumentType DocumentType { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("supplierVatNumber")]
    public string? SupplierVatNumber { get; set; }

    [JsonPropertyName("customerVatNumber")]
    public string? CustomerVatNumber { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<EuDigitalReportingListDeclarationsResponseTransactionsItemLinesItem> Lines { get; set; } =
        new List<EuDigitalReportingListDeclarationsResponseTransactionsItemLinesItem>();

    [JsonPropertyName("taxableAmount")]
    public required string TaxableAmount { get; set; }

    [JsonPropertyName("vatAmount")]
    public string? VatAmount { get; set; }

    [JsonPropertyName("exemptionReference")]
    public string? ExemptionReference { get; set; }

    [JsonPropertyName("reverseCharge")]
    public required bool ReverseCharge { get; set; }

    [JsonPropertyName("correctedInvoiceNumber")]
    public string? CorrectedInvoiceNumber { get; set; }

    [JsonPropertyName("supplierAccounts")]
    public IEnumerable<string> SupplierAccounts { get; set; } = new List<string>();

    [JsonPropertyName("reportTo")]
    public required string ReportTo { get; set; }

    [JsonPropertyName("deadline")]
    public required string Deadline { get; set; }

    [JsonPropertyName("missing")]
    public IEnumerable<string> Missing { get; set; } = new List<string>();

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

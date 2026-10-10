using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesLockSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public required InvoicesLockSalesResponseType Type { get; set; }

    [JsonPropertyName("status")]
    public required InvoicesLockSalesResponseStatus Status { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required InvoicesLockSalesResponsePaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("number")]
    public long? Number { get; set; }

    [JsonPropertyName("fullNumber")]
    public string? FullNumber { get; set; }

    [JsonPropertyName("issueDate")]
    public DateOnly? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("fxRate")]
    public string? FxRate { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public required string VatTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paidAmount")]
    public required string PaidAmount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("appliedToInvoiceId")]
    public string? AppliedToInvoiceId { get; set; }

    [JsonPropertyName("creditedInvoiceId")]
    public string? CreditedInvoiceId { get; set; }

    [JsonPropertyName("creditedInvoiceReference")]
    public string? CreditedInvoiceReference { get; set; }

    [JsonPropertyName("creditedInvoiceDate")]
    public DateOnly? CreditedInvoiceDate { get; set; }

    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; set; }

    [JsonPropertyName("vatScheme")]
    public InvoicesLockSalesResponseVatScheme? VatScheme { get; set; }

    [JsonPropertyName("intrastatTransportMode")]
    public string? IntrastatTransportMode { get; set; }

    [JsonPropertyName("intrastatDeliveryTerms")]
    public string? IntrastatDeliveryTerms { get; set; }

    [JsonPropertyName("intrastatRegion")]
    public string? IntrastatRegion { get; set; }

    [JsonPropertyName("intrastatNatureOfTransaction")]
    public string? IntrastatNatureOfTransaction { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("deemedSupplier")]
    public required bool DeemedSupplier { get; set; }

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

    [JsonPropertyName("discountPercent")]
    public required string DiscountPercent { get; set; }

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

    [JsonPropertyName("lockedAt")]
    public DateTime? LockedAt { get; set; }

    [JsonPropertyName("lockedBy")]
    public string? LockedBy { get; set; }

    [JsonPropertyName("payToken")]
    public string? PayToken { get; set; }

    [JsonPropertyName("einvoiceSystem")]
    public string? EinvoiceSystem { get; set; }

    [JsonPropertyName("einvoiceTransport")]
    public string? EinvoiceTransport { get; set; }

    [JsonPropertyName("einvoiceMessageId")]
    public string? EinvoiceMessageId { get; set; }

    [JsonPropertyName("einvoiceNumber")]
    public string? EinvoiceNumber { get; set; }

    [JsonPropertyName("einvoiceStatus")]
    public string? EinvoiceStatus { get; set; }

    [JsonPropertyName("einvoiceDetail")]
    public string? EinvoiceDetail { get; set; }

    [JsonPropertyName("einvoiceSentAt")]
    public DateTime? EinvoiceSentAt { get; set; }

    [JsonPropertyName("einvoiceCheckedAt")]
    public DateTime? EinvoiceCheckedAt { get; set; }

    [JsonPropertyName("peppolMessageId")]
    public string? PeppolMessageId { get; set; }

    [JsonPropertyName("peppolStatus")]
    public string? PeppolStatus { get; set; }

    [JsonPropertyName("peppolDetail")]
    public string? PeppolDetail { get; set; }

    [JsonPropertyName("peppolSentAt")]
    public DateTime? PeppolSentAt { get; set; }

    [JsonPropertyName("peppolCheckedAt")]
    public DateTime? PeppolCheckedAt { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Gross amount of an advance invoice applied to final invoices so far; null on other documents
    /// </summary>
    [JsonPropertyName("advanceAppliedAmount")]
    public string? AdvanceAppliedAmount { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<InvoicesLockSalesResponseLinesItem> Lines { get; set; } =
        new List<InvoicesLockSalesResponseLinesItem>();

    [JsonPropertyName("vatEvidence")]
    public InvoicesLockSalesResponseVatEvidence? VatEvidence { get; set; }

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

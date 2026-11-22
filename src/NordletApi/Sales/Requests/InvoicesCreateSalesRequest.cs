using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesCreateSalesRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public InvoicesCreateSalesRequestType? Type { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("issueDate")]
    public DateOnly? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("creditedInvoiceId")]
    public string? CreditedInvoiceId { get; set; }

    /// <summary>
    /// Number of an original invoice issued outside Nordlet; give it with creditedInvoiceDate
    /// </summary>
    [JsonPropertyName("creditedInvoiceReference")]
    public string? CreditedInvoiceReference { get; set; }

    /// <summary>
    /// Issue date of the original invoice issued outside Nordlet
    /// </summary>
    [JsonPropertyName("creditedInvoiceDate")]
    public DateOnly? CreditedInvoiceDate { get; set; }

    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; set; }

    [JsonPropertyName("vatScheme")]
    public InvoicesCreateSalesRequestVatScheme? VatScheme { get; set; }

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
    public bool? DeemedSupplier { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    /// <summary>
    /// Language of the PDF and of the e-mail the invoice is sent with; unset means the language asked for when the PDF is made
    /// </summary>
    [JsonPropertyName("locale")]
    public InvoicesCreateSalesRequestLocale? Locale { get; set; }

    /// <summary>
    /// Whether the PDF and the e-mail carry the payment link of the company payment link template
    /// </summary>
    [JsonPropertyName("payLinkEnabled")]
    public bool? PayLinkEnabled { get; set; }

    /// <summary>
    /// Whether automatic debt reminders include this invoice when its partner has them turned on
    /// </summary>
    [JsonPropertyName("debtRemindersEnabled")]
    public bool? DebtRemindersEnabled { get; set; }

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

    /// <summary>
    /// Sales tax as a percent of the net total, added to the document total and posted to the sales tax payable account when the document is issued. US companies only (422 otherwise); invoices and credit notes only.
    /// </summary>
    [JsonPropertyName("salesTaxPercent")]
    public string? SalesTaxPercent { get; set; }

    /// <summary>
    /// The US state the sales tax is collected for, as an ISO 3166-2 code such as `US-CA`; unset means the state of `deliveryAddress` (422 when it has none), else the credited invoice's state for a credit note, else the state of the customer's address (422 without one). When the customer has a certificate of exemption for that state (`partners/sales-tax-exemptions/create`) that covers the sale, no sales tax is charged and the document keeps the certificate's id in `salesTaxExemptionId`.
    /// </summary>
    [JsonPropertyName("salesTaxJurisdiction")]
    public string? SalesTaxJurisdiction { get; set; }

    /// <summary>
    /// Where the goods or services are delivered, when not at the customer's address; it decides the state of the sales tax when `salesTaxJurisdiction` is not given.
    /// </summary>
    [JsonPropertyName("deliveryAddress")]
    public InvoicesCreateSalesRequestDeliveryAddress? DeliveryAddress { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<InvoicesCreateSalesRequestLinesItem> Lines { get; set; } =
        new List<InvoicesCreateSalesRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

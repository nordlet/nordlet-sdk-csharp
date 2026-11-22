using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FindOrCreatePartnersRequest
{
    [JsonPropertyName("type")]
    public FindOrCreatePartnersRequestType? Type { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("peppolId")]
    public string? PeppolId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("selfEmploymentCertNo")]
    public string? SelfEmploymentCertNo { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    /// <summary>
    /// Whether the partner acts as a business for VAT; when not set, a partner with a VAT code is a business. Regulation (EU) 282/2011 art. 18 lets a customer without a VAT number be treated as a business on other proof
    /// </summary>
    [JsonPropertyName("isBusiness")]
    public bool? IsBusiness { get; set; }

    [JsonPropertyName("isCustomer")]
    public bool? IsCustomer { get; set; }

    [JsonPropertyName("isSupplier")]
    public bool? IsSupplier { get; set; }

    [JsonPropertyName("paymentTermDays")]
    public long? PaymentTermDays { get; set; }

    /// <summary>
    /// Currency a new invoice for this partner starts with when the invoice names none
    /// </summary>
    [JsonPropertyName("invoiceCurrency")]
    public FindOrCreatePartnersRequestInvoiceCurrency? InvoiceCurrency { get; set; }

    /// <summary>
    /// Language a new invoice for this partner starts with when the invoice names none
    /// </summary>
    [JsonPropertyName("invoiceLocale")]
    public FindOrCreatePartnersRequestInvoiceLocale? InvoiceLocale { get; set; }

    [JsonPropertyName("creditLimit")]
    public string? CreditLimit { get; set; }

    [JsonPropertyName("priceListId")]
    public string? PriceListId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("statusId")]
    public string? StatusId { get; set; }

    [JsonPropertyName("address")]
    public FindOrCreatePartnersRequestAddress? Address { get; set; }

    [JsonPropertyName("correspondenceAddress")]
    public FindOrCreatePartnersRequestCorrespondenceAddress? CorrespondenceAddress { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("fax")]
    public string? Fax { get; set; }

    [JsonPropertyName("eoriCode")]
    public string? EoriCode { get; set; }

    [JsonPropertyName("autoDebtReminder")]
    public bool? AutoDebtReminder { get; set; }

    [JsonPropertyName("lateInterestPercent")]
    public string? LateInterestPercent { get; set; }

    [JsonPropertyName("firstCallDate")]
    public DateOnly? FirstCallDate { get; set; }

    [JsonPropertyName("lastCallDate")]
    public DateOnly? LastCallDate { get; set; }

    [JsonPropertyName("nextCallDate")]
    public DateOnly? NextCallDate { get; set; }

    [JsonPropertyName("rating")]
    public long? Rating { get; set; }

    [JsonPropertyName("isEmployee")]
    public bool? IsEmployee { get; set; }

    [JsonPropertyName("isGroupMember")]
    public bool? IsGroupMember { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    [JsonPropertyName("legalCountryClass")]
    public FindOrCreatePartnersRequestLegalCountryClass? LegalCountryClass { get; set; }

    /// <summary>
    /// Tax data of the partner by key, checked against the company's country: `tin` (US, Taxpayer identification number (TIN) from Form W-9, 9 digits); `tinType` (US, Type of the taxpayer identification number, SSN, EIN, ITIN or ATIN); `taxClassification` (US, Federal tax classification (Form W-9, line 3a), individual, c-corporation, s-corporation, partnership, trust-estate, llc-c, llc-s, llc-p, other); `nonemployeeCompensation` (US, Paid for services as nonemployee compensation (Form 1099-NEC, box 1), yes or no)
    /// </summary>
    [JsonPropertyName("identifiers")]
    public Dictionary<string, string>? Identifiers { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesUpdateAccountRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("smeExemptionNumber")]
    public string? SmeExemptionNumber { get; set; }

    [JsonPropertyName("isVatPayer")]
    public bool? IsVatPayer { get; set; }

    [JsonPropertyName("vatPeriod")]
    public CompaniesUpdateAccountRequestVatPeriod? VatPeriod { get; set; }

    [JsonPropertyName("fiscalYearEndMonth")]
    public long? FiscalYearEndMonth { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("filingOptions")]
    public Dictionary<string, string?>? FilingOptions { get; set; }

    [JsonPropertyName("address")]
    public CompaniesUpdateAccountRequestAddress? Address { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("bankName")]
    public string? BankName { get; set; }

    [JsonPropertyName("peppolId")]
    public string? PeppolId { get; set; }

    [JsonPropertyName("sepaCreditorId")]
    public string? SepaCreditorId { get; set; }

    [JsonPropertyName("defaultInvoiceCurrency")]
    public string? DefaultInvoiceCurrency { get; set; }

    [JsonPropertyName("legalForm")]
    public string? LegalForm { get; set; }

    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    [JsonPropertyName("incorporatedOn")]
    public DateOnly? IncorporatedOn { get; set; }

    [JsonPropertyName("shareCapital")]
    public string? ShareCapital { get; set; }

    [JsonPropertyName("accountsKeptBy")]
    public CompaniesUpdateAccountRequestAccountsKeptBy? AccountsKeptBy { get; set; }

    [JsonPropertyName("bookkeeperName")]
    public string? BookkeeperName { get; set; }

    [JsonPropertyName("auditorName")]
    public string? AuditorName { get; set; }

    [JsonPropertyName("auditorRegistrationNumber")]
    public string? AuditorRegistrationNumber { get; set; }

    [JsonPropertyName("auditRequired")]
    public bool? AuditRequired { get; set; }

    [JsonPropertyName("logo")]
    public CompaniesUpdateAccountRequestLogo? Logo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

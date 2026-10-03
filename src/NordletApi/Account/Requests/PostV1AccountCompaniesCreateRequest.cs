using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountCompaniesCreateRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("smeExemptionNumber")]
    public string? SmeExemptionNumber { get; set; }

    [JsonPropertyName("isVatPayer")]
    public bool? IsVatPayer { get; set; }

    [JsonPropertyName("vatPeriod")]
    public PostV1AccountCompaniesCreateRequestVatPeriod? VatPeriod { get; set; }

    [JsonPropertyName("fiscalYearEndMonth")]
    public long? FiscalYearEndMonth { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("filingOptions")]
    public Dictionary<string, string>? FilingOptions { get; set; }

    [JsonPropertyName("address")]
    public PostV1AccountCompaniesCreateRequestAddress? Address { get; set; }

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
    public string? IncorporatedOn { get; set; }

    [JsonPropertyName("shareCapital")]
    public string? ShareCapital { get; set; }

    [JsonPropertyName("accountsKeptBy")]
    public PostV1AccountCompaniesCreateRequestAccountsKeptBy? AccountsKeptBy { get; set; }

    [JsonPropertyName("bookkeeperName")]
    public string? BookkeeperName { get; set; }

    [JsonPropertyName("auditorName")]
    public string? AuditorName { get; set; }

    [JsonPropertyName("auditorRegistrationNumber")]
    public string? AuditorRegistrationNumber { get; set; }

    [JsonPropertyName("auditRequired")]
    public bool? AuditRequired { get; set; }

    /// <summary>
    /// Jurisdiction the company is registered in (immutable after creation)
    /// </summary>
    [JsonPropertyName("countryCode")]
    public PostV1AccountCompaniesCreateRequestCountryCode? CountryCode { get; set; }

    /// <summary>
    /// Sandbox companies hold test data and are purged immediately on delete (immutable after creation)
    /// </summary>
    [JsonPropertyName("isSandbox")]
    public bool? IsSandbox { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

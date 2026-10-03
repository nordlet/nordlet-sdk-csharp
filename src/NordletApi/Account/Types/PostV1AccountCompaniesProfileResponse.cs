using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountCompaniesProfileResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("smeExemptionNumber")]
    public string? SmeExemptionNumber { get; set; }

    [JsonPropertyName("isVatPayer")]
    public required bool IsVatPayer { get; set; }

    [JsonPropertyName("isSandbox")]
    public required bool IsSandbox { get; set; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Chart of accounts template the company was seeded with
    /// </summary>
    [JsonPropertyName("chartTemplate")]
    public required string ChartTemplate { get; set; }

    /// <summary>
    /// Chart of accounts template of the company country
    /// </summary>
    [JsonPropertyName("countryChartTemplate")]
    public required string CountryChartTemplate { get; set; }

    [JsonPropertyName("baseCurrency")]
    public required string BaseCurrency { get; set; }

    [JsonPropertyName("defaultInvoiceCurrency")]
    public required string DefaultInvoiceCurrency { get; set; }

    [JsonPropertyName("status")]
    public required PostV1AccountCompaniesProfileResponseStatus Status { get; set; }

    [JsonPropertyName("address")]
    public PostV1AccountCompaniesProfileResponseAddress? Address { get; set; }

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

    [JsonPropertyName("logoFileId")]
    public string? LogoFileId { get; set; }

    [JsonPropertyName("legalForm")]
    public string? LegalForm { get; set; }

    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    [JsonPropertyName("incorporatedOn")]
    public string? IncorporatedOn { get; set; }

    [JsonPropertyName("shareCapital")]
    public string? ShareCapital { get; set; }

    [JsonPropertyName("accountsKeptBy")]
    public PostV1AccountCompaniesProfileResponseAccountsKeptBy? AccountsKeptBy { get; set; }

    [JsonPropertyName("vatPeriod")]
    public PostV1AccountCompaniesProfileResponseVatPeriod? VatPeriod { get; set; }

    [JsonPropertyName("fiscalYearEndMonth")]
    public long? FiscalYearEndMonth { get; set; }

    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }

    [JsonPropertyName("filingOptions")]
    public Dictionary<string, string?>? FilingOptions { get; set; }

    [JsonPropertyName("bookkeeperName")]
    public string? BookkeeperName { get; set; }

    [JsonPropertyName("auditorName")]
    public string? AuditorName { get; set; }

    [JsonPropertyName("auditorRegistrationNumber")]
    public string? AuditorRegistrationNumber { get; set; }

    [JsonPropertyName("auditRequired")]
    public required bool AuditRequired { get; set; }

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

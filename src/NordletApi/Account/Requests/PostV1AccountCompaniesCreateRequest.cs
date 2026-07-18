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

    [JsonPropertyName("defaultInvoiceCurrency")]
    public string? DefaultInvoiceCurrency { get; set; }

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

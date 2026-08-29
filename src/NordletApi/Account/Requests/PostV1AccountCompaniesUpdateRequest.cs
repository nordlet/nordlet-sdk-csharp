using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountCompaniesUpdateRequest
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

    [JsonPropertyName("address")]
    public PostV1AccountCompaniesUpdateRequestAddress? Address { get; set; }

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

    [JsonPropertyName("logo")]
    public PostV1AccountCompaniesUpdateRequestLogo? Logo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

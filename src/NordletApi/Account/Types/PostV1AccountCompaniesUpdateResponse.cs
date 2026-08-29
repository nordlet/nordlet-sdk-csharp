using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountCompaniesUpdateResponse : IJsonOnDeserialized
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

    [JsonPropertyName("baseCurrency")]
    public required string BaseCurrency { get; set; }

    [JsonPropertyName("defaultInvoiceCurrency")]
    public required string DefaultInvoiceCurrency { get; set; }

    [JsonPropertyName("status")]
    public required PostV1AccountCompaniesUpdateResponseStatus Status { get; set; }

    [JsonPropertyName("address")]
    public PostV1AccountCompaniesUpdateResponseAddress? Address { get; set; }

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1PartnersUpdateResponseType Type { get; set; }

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
    public string? BirthDate { get; set; }

    [JsonPropertyName("isCustomer")]
    public required bool IsCustomer { get; set; }

    [JsonPropertyName("isSupplier")]
    public required bool IsSupplier { get; set; }

    [JsonPropertyName("paymentTermDays")]
    public long? PaymentTermDays { get; set; }

    [JsonPropertyName("creditLimit")]
    public string? CreditLimit { get; set; }

    [JsonPropertyName("priceListId")]
    public string? PriceListId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("statusId")]
    public string? StatusId { get; set; }

    [JsonPropertyName("vatValid")]
    public bool? VatValid { get; set; }

    [JsonPropertyName("vatValidatedAt")]
    public string? VatValidatedAt { get; set; }

    [JsonPropertyName("address")]
    public PostV1PartnersUpdateResponseAddress? Address { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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

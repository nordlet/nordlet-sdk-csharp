using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1PartnersListResponseRowsItemType Type { get; set; }

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
    public PostV1PartnersListResponseRowsItemAddress? Address { get; set; }

    [JsonPropertyName("correspondenceAddress")]
    public PostV1PartnersListResponseRowsItemCorrespondenceAddress? CorrespondenceAddress { get; set; }

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

    [JsonPropertyName("otherCode")]
    public string? OtherCode { get; set; }

    [JsonPropertyName("foreignTaxNumber")]
    public string? ForeignTaxNumber { get; set; }

    [JsonPropertyName("autoDebtReminder")]
    public required bool AutoDebtReminder { get; set; }

    [JsonPropertyName("lateInterestPercent")]
    public string? LateInterestPercent { get; set; }

    [JsonPropertyName("firstCallDate")]
    public string? FirstCallDate { get; set; }

    [JsonPropertyName("lastCallDate")]
    public string? LastCallDate { get; set; }

    [JsonPropertyName("nextCallDate")]
    public string? NextCallDate { get; set; }

    [JsonPropertyName("rating")]
    public long? Rating { get; set; }

    [JsonPropertyName("isEmployee")]
    public required bool IsEmployee { get; set; }

    [JsonPropertyName("isGroupMember")]
    public required bool IsGroupMember { get; set; }

    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("legalCountryClass")]
    public PostV1PartnersListResponseRowsItemLegalCountryClass? LegalCountryClass { get; set; }

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

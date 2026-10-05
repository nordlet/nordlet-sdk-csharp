using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CreatePartnersRequest
{
    [JsonPropertyName("type")]
    public CreatePartnersRequestType? Type { get; set; }

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

    [JsonPropertyName("isCustomer")]
    public bool? IsCustomer { get; set; }

    [JsonPropertyName("isSupplier")]
    public bool? IsSupplier { get; set; }

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

    [JsonPropertyName("address")]
    public CreatePartnersRequestAddress? Address { get; set; }

    [JsonPropertyName("correspondenceAddress")]
    public CreatePartnersRequestCorrespondenceAddress? CorrespondenceAddress { get; set; }

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
    public CreatePartnersRequestLegalCountryClass? LegalCountryClass { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

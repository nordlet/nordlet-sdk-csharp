using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersCreateRequest
{
    [JsonPropertyName("type")]
    public PostV1PartnersCreateRequestType? Type { get; set; }

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
    public PostV1PartnersCreateRequestAddress? Address { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

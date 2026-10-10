using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdatePlatformSellersRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("kind")]
    public required UpdatePlatformSellersRequestKind Kind { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    [JsonPropertyName("taxResidences")]
    public IEnumerable<UpdatePlatformSellersRequestTaxResidencesItem>? TaxResidences { get; set; }

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("businessRegistrationNumber")]
    public string? BusinessRegistrationNumber { get; set; }

    [JsonPropertyName("address")]
    public required UpdatePlatformSellersRequestAddress Address { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("birthCity")]
    public string? BirthCity { get; set; }

    [JsonPropertyName("birthCountryCode")]
    public string? BirthCountryCode { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("accountHolderName")]
    public string? AccountHolderName { get; set; }

    [JsonPropertyName("governmentEntity")]
    public bool? GovernmentEntity { get; set; }

    [JsonPropertyName("listedEntity")]
    public bool? ListedEntity { get; set; }

    [JsonPropertyName("permanentEstablishments")]
    public IEnumerable<string>? PermanentEstablishments { get; set; }

    [JsonPropertyName("activities")]
    public IEnumerable<UpdatePlatformSellersRequestActivitiesItem>? Activities { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

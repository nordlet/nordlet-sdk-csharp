using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ListPlatformSellersResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("kind")]
    public required ListPlatformSellersResponseRowsItemKind Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
    public IEnumerable<ListPlatformSellersResponseRowsItemTaxResidencesItem> TaxResidences { get; set; } =
        new List<ListPlatformSellersResponseRowsItemTaxResidencesItem>();

    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("businessRegistrationNumber")]
    public string? BusinessRegistrationNumber { get; set; }

    [JsonPropertyName("address")]
    public required ListPlatformSellersResponseRowsItemAddress Address { get; set; }

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
    public required bool GovernmentEntity { get; set; }

    [JsonPropertyName("listedEntity")]
    public required bool ListedEntity { get; set; }

    [JsonPropertyName("permanentEstablishments")]
    public IEnumerable<string> PermanentEstablishments { get; set; } = new List<string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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

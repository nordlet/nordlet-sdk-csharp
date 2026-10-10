using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GetPlatformSellersResponseActivitiesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("activity")]
    public required GetPlatformSellersResponseActivitiesItemActivity Activity { get; set; }

    [JsonPropertyName("propertyAddress")]
    public GetPlatformSellersResponseActivitiesItemPropertyAddress? PropertyAddress { get; set; }

    [JsonPropertyName("landRegistrationNumber")]
    public string? LandRegistrationNumber { get; set; }

    [JsonPropertyName("propertyType")]
    public GetPlatformSellersResponseActivitiesItemPropertyType? PropertyType { get; set; }

    [JsonPropertyName("otherPropertyType")]
    public string? OtherPropertyType { get; set; }

    [JsonPropertyName("rentedDays")]
    public long? RentedDays { get; set; }

    [JsonPropertyName("consideration")]
    public IEnumerable<string> Consideration { get; set; } = new List<string>();

    [JsonPropertyName("fees")]
    public IEnumerable<string> Fees { get; set; } = new List<string>();

    [JsonPropertyName("taxes")]
    public IEnumerable<string> Taxes { get; set; } = new List<string>();

    [JsonPropertyName("numberOfActivities")]
    public IEnumerable<long> NumberOfActivities { get; set; } = new List<long>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

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

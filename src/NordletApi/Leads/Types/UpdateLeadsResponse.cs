using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdateLeadsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("contactName")]
    public string? ContactName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("sourceId")]
    public string? SourceId { get; set; }

    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    [JsonPropertyName("status")]
    public required UpdateLeadsResponseStatus Status { get; set; }

    [JsonPropertyName("estimatedValue")]
    public string? EstimatedValue { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("convertedAt")]
    public DateTime? ConvertedAt { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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

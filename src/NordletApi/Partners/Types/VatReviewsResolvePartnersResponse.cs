using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatReviewsResolvePartnersResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("vatCode")]
    public required string VatCode { get; set; }

    [JsonPropertyName("reason")]
    public required VatReviewsResolvePartnersResponseReason Reason { get; set; }

    [JsonPropertyName("status")]
    public required VatReviewsResolvePartnersResponseStatus Status { get; set; }

    [JsonPropertyName("resolution")]
    public VatReviewsResolvePartnersResponseResolution? Resolution { get; set; }

    [JsonPropertyName("resolutionNote")]
    public string? ResolutionNote { get; set; }

    [JsonPropertyName("details")]
    public VatReviewsResolvePartnersResponseDetails? Details { get; set; }

    [JsonPropertyName("resolvedAt")]
    public DateTime? ResolvedAt { get; set; }

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

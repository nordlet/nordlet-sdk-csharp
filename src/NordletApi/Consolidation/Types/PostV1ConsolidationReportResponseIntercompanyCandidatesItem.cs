using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseIntercompanyCandidatesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("memberCompanyId")]
    public required string MemberCompanyId { get; set; }

    [JsonPropertyName("memberName")]
    public required string MemberName { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("partnerCode")]
    public string? PartnerCode { get; set; }

    [JsonPropertyName("matchesCompanyId")]
    public required string MatchesCompanyId { get; set; }

    [JsonPropertyName("matchesCompanyName")]
    public required string MatchesCompanyName { get; set; }

    [JsonPropertyName("matchedOn")]
    public required PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn MatchedOn { get; set; }

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

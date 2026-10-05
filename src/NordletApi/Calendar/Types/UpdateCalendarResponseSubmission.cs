using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdateCalendarResponseSubmission : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("obligation")]
    public required string Obligation { get; set; }

    [JsonPropertyName("periodYear")]
    public required long PeriodYear { get; set; }

    [JsonPropertyName("periodMonth")]
    public long? PeriodMonth { get; set; }

    [JsonPropertyName("variant")]
    public string? Variant { get; set; }

    [JsonPropertyName("status")]
    public required UpdateCalendarResponseSubmissionStatus Status { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ruleKey")]
    public string? RuleKey { get; set; }

    [JsonPropertyName("period")]
    public string? Period { get; set; }

    [JsonPropertyName("documentKey")]
    public string? DocumentKey { get; set; }

    [JsonPropertyName("amendment")]
    public required long Amendment { get; set; }

    [JsonPropertyName("origin")]
    public required string Origin { get; set; }

    [JsonPropertyName("transportSystem")]
    public string? TransportSystem { get; set; }

    [JsonPropertyName("environment")]
    public UpdateCalendarResponseSubmissionEnvironment? Environment { get; set; }

    [JsonPropertyName("submittedAt")]
    public DateTime? SubmittedAt { get; set; }

    [JsonPropertyName("acceptedAt")]
    public DateTime? AcceptedAt { get; set; }

    [JsonPropertyName("rejectedAt")]
    public DateTime? RejectedAt { get; set; }

    [JsonPropertyName("checkedAt")]
    public DateTime? CheckedAt { get; set; }

    [JsonPropertyName("nextCheckAt")]
    public DateTime? NextCheckAt { get; set; }

    [JsonPropertyName("attempts")]
    public required long Attempts { get; set; }

    [JsonPropertyName("deliveryError")]
    public string? DeliveryError { get; set; }

    [JsonPropertyName("sentSha256")]
    public string? SentSha256 { get; set; }

    [JsonPropertyName("certificateFingerprint")]
    public string? CertificateFingerprint { get; set; }

    [JsonPropertyName("submittedByActorType")]
    public string? SubmittedByActorType { get; set; }

    [JsonPropertyName("submittedByActorId")]
    public string? SubmittedByActorId { get; set; }

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

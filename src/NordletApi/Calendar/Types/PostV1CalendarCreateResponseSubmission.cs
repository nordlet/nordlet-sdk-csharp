using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CalendarCreateResponseSubmission : IJsonOnDeserialized
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
    public required PostV1CalendarCreateResponseSubmissionStatus Status { get; set; }

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

    [JsonPropertyName("origin")]
    public required string Origin { get; set; }

    [JsonPropertyName("transportSystem")]
    public string? TransportSystem { get; set; }

    [JsonPropertyName("submittedAt")]
    public string? SubmittedAt { get; set; }

    [JsonPropertyName("acceptedAt")]
    public string? AcceptedAt { get; set; }

    [JsonPropertyName("rejectedAt")]
    public string? RejectedAt { get; set; }

    [JsonPropertyName("checkedAt")]
    public string? CheckedAt { get; set; }

    [JsonPropertyName("nextCheckAt")]
    public string? NextCheckAt { get; set; }

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CreateCalendarResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("kind")]
    public required CreateCalendarResponseKind Kind { get; set; }

    [JsonPropertyName("ruleKey")]
    public string? RuleKey { get; set; }

    [JsonPropertyName("period")]
    public string? Period { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("dueDate")]
    public required DateOnly DueDate { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("done")]
    public required bool Done { get; set; }

    [JsonPropertyName("href")]
    public string? Href { get; set; }

    [JsonPropertyName("submission")]
    public CreateCalendarResponseSubmission? Submission { get; set; }

    [JsonPropertyName("submissions")]
    public IEnumerable<CreateCalendarResponseSubmissionsItem> Submissions { get; set; } =
        new List<CreateCalendarResponseSubmissionsItem>();

    [JsonPropertyName("canSubmit")]
    public required bool CanSubmit { get; set; }

    [JsonPropertyName("canAmend")]
    public required bool CanAmend { get; set; }

    [JsonPropertyName("canDownload")]
    public required bool CanDownload { get; set; }

    [JsonPropertyName("automated")]
    public required bool Automated { get; set; }

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

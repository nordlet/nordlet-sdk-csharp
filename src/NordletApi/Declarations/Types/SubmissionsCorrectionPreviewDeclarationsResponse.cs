using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SubmissionsCorrectionPreviewDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("needed")]
    public required bool Needed { get; set; }

    [JsonPropertyName("changeCount")]
    public required long ChangeCount { get; set; }

    [JsonPropertyName("changes")]
    public IEnumerable<SubmissionsCorrectionPreviewDeclarationsResponseChangesItem> Changes { get; set; } =
        new List<SubmissionsCorrectionPreviewDeclarationsResponseChangesItem>();

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

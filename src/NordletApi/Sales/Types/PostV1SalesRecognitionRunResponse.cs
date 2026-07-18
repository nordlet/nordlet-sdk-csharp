using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionRunResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("runId")]
    public required string RunId { get; set; }

    [JsonPropertyName("runDate")]
    public required string RunDate { get; set; }

    [JsonPropertyName("trigger")]
    public required PostV1SalesRecognitionRunResponseTrigger Trigger { get; set; }

    [JsonPropertyName("scheduleCount")]
    public required long ScheduleCount { get; set; }

    [JsonPropertyName("totalAmount")]
    public required string TotalAmount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public required string JournalTransactionId { get; set; }

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

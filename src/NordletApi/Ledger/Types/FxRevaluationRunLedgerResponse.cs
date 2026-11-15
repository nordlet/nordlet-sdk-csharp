using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FxRevaluationRunLedgerResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("runId")]
    public string? RunId { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("reversalDate")]
    public required DateOnly ReversalDate { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("reversalJournalTransactionId")]
    public string? ReversalJournalTransactionId { get; set; }

    [JsonPropertyName("gain")]
    public required string Gain { get; set; }

    [JsonPropertyName("loss")]
    public required string Loss { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<FxRevaluationRunLedgerResponseLinesItem> Lines { get; set; } =
        new List<FxRevaluationRunLedgerResponseLinesItem>();

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

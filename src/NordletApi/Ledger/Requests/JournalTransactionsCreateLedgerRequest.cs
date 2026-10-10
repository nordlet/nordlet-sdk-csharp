using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record JournalTransactionsCreateLedgerRequest
{
    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<JournalTransactionsCreateLedgerRequestEntriesItem> Entries { get; set; } =
        new List<JournalTransactionsCreateLedgerRequestEntriesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerJournalTransactionsCreateRequest
{
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<PostV1LedgerJournalTransactionsCreateRequestEntriesItem> Entries { get; set; } =
        new List<PostV1LedgerJournalTransactionsCreateRequestEntriesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

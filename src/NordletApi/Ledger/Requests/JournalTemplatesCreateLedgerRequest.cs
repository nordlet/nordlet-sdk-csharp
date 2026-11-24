using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record JournalTemplatesCreateLedgerRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<JournalTemplatesCreateLedgerRequestLinesItem> Lines { get; set; } =
        new List<JournalTemplatesCreateLedgerRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

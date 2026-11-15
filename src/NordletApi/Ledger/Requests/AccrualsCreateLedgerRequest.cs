using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccrualsCreateLedgerRequest
{
    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<AccrualsCreateLedgerRequestLinesItem> Lines { get; set; } =
        new List<AccrualsCreateLedgerRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostingRulesUpdateLedgerRequest
{
    [JsonPropertyName("rules")]
    public IEnumerable<PostingRulesUpdateLedgerRequestRulesItem> Rules { get; set; } =
        new List<PostingRulesUpdateLedgerRequestRulesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

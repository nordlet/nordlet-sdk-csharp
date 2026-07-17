using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerPostingRulesUpdateRequest
{
    [JsonPropertyName("rules")]
    public IEnumerable<PostV1LedgerPostingRulesUpdateRequestRulesItem> Rules { get; set; } =
        new List<PostV1LedgerPostingRulesUpdateRequestRulesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DeReturnsGenerateDeclarationsRequest
{
    [JsonPropertyName("ruleKey")]
    public required DeReturnsGenerateDeclarationsRequestRuleKey RuleKey { get; set; }

    [JsonPropertyName("period")]
    public required string Period { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

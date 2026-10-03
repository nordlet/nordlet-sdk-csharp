using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsDeReturnsGenerateRequest
{
    [JsonPropertyName("ruleKey")]
    public required PostV1DeclarationsDeReturnsGenerateRequestRuleKey RuleKey { get; set; }

    [JsonPropertyName("period")]
    public required string Period { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsAutomationUpdateRequest
{
    [JsonPropertyName("ruleKey")]
    public required string RuleKey { get; set; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

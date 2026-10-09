using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MergePartnersRequest
{
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; set; }

    [JsonPropertyName("targetId")]
    public required string TargetId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

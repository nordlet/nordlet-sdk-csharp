using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsPlKsefReceivedListRequest
{
    [JsonPropertyName("from")]
    public required DateTime From { get; set; }

    [JsonPropertyName("to")]
    public required DateTime To { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    [JsonPropertyName("pageOffset")]
    public long? PageOffset { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

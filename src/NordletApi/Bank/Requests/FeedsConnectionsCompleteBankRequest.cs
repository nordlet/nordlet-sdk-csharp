using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FeedsConnectionsCompleteBankRequest
{
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

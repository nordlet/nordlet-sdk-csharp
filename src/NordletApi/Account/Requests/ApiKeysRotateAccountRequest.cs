using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ApiKeysRotateAccountRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("overlapHours")]
    public long? OverlapHours { get; set; }

    [JsonPropertyName("expiresInDays")]
    public long? ExpiresInDays { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

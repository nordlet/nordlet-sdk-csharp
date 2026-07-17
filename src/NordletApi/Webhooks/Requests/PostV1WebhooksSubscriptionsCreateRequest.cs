using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1WebhooksSubscriptionsCreateRequest
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("events")]
    public IEnumerable<string> Events { get; set; } = new List<string>();

    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

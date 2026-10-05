using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SubscriptionsCreateWebhooksRequest
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("events")]
    public IEnumerable<SubscriptionsCreateWebhooksRequestEventsItem> Events { get; set; } =
        new List<SubscriptionsCreateWebhooksRequestEventsItem>();

    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

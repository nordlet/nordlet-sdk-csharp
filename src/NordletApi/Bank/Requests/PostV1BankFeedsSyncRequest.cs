using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsSyncRequest
{
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    [JsonPropertyName("feedAccountId")]
    public string? FeedAccountId { get; set; }

    [JsonPropertyName("dateFrom")]
    public string? DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public string? DateTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

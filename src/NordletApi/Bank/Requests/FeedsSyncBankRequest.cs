using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FeedsSyncBankRequest
{
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    [JsonPropertyName("feedAccountId")]
    public string? FeedAccountId { get; set; }

    [JsonPropertyName("dateFrom")]
    public DateOnly? DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public DateOnly? DateTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

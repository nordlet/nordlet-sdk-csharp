using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingUsageListRequest
{
    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

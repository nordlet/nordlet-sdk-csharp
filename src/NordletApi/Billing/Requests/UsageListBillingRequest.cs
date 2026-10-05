using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsageListBillingRequest
{
    [JsonPropertyName("from")]
    public required DateOnly From { get; set; }

    [JsonPropertyName("to")]
    public required DateOnly To { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

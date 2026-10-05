using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuDistanceSalesThresholdGetDeclarationsRequest
{
    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

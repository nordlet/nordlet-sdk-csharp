using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtFr0600ComputeRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("months")]
    public long? Months { get; set; }

    [JsonPropertyName("deductionPercent")]
    public long? DeductionPercent { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

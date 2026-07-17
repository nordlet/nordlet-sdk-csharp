using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtGpm313ComputeRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("payoutTiming")]
    public PostV1DeclarationsLtGpm313ComputeRequestPayoutTiming? PayoutTiming { get; set; }

    [JsonPropertyName("paymentDay")]
    public long? PaymentDay { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

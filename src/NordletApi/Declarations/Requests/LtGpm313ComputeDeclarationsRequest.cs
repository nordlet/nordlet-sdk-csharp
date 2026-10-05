using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtGpm313ComputeDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("payoutTiming")]
    public LtGpm313ComputeDeclarationsRequestPayoutTiming? PayoutTiming { get; set; }

    [JsonPropertyName("paymentDay")]
    public long? PaymentDay { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

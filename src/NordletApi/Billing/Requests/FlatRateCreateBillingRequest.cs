using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FlatRateCreateBillingRequest
{
    [JsonPropertyName("locale")]
    public FlatRateCreateBillingRequestLocale? Locale { get; set; }

    [JsonPropertyName("plan")]
    public FlatRateCreateBillingRequestPlan? Plan { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

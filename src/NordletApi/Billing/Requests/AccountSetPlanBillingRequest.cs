using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountSetPlanBillingRequest
{
    [JsonPropertyName("plan")]
    public required AccountSetPlanBillingRequestPlan Plan { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

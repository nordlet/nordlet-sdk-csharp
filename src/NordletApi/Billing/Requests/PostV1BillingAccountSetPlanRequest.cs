using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingAccountSetPlanRequest
{
    [JsonPropertyName("plan")]
    public required PostV1BillingAccountSetPlanRequestPlan Plan { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

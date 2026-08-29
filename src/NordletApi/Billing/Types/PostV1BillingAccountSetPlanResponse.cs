using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingAccountSetPlanResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("plan")]
    public required PostV1BillingAccountSetPlanResponsePlan Plan { get; set; }

    [JsonPropertyName("status")]
    public required PostV1BillingAccountSetPlanResponseStatus Status { get; set; }

    [JsonPropertyName("balanceCents")]
    public required long BalanceCents { get; set; }

    [JsonPropertyName("trialEndsAt")]
    public string? TrialEndsAt { get; set; }

    [JsonPropertyName("firstTopUpAt")]
    public string? FirstTopUpAt { get; set; }

    [JsonPropertyName("lastChargedDate")]
    public string? LastChargedDate { get; set; }

    [JsonPropertyName("paymentsConfigured")]
    public required bool PaymentsConfigured { get; set; }

    [JsonPropertyName("monthToDate")]
    public required PostV1BillingAccountSetPlanResponseMonthToDate MonthToDate { get; set; }

    [JsonPropertyName("plans")]
    public Dictionary<string, PostV1BillingAccountSetPlanResponsePlansValue> Plans { get; set; } =
        new Dictionary<string, PostV1BillingAccountSetPlanResponsePlansValue>();

    [JsonPropertyName("topUp")]
    public required PostV1BillingAccountSetPlanResponseTopUp TopUp { get; set; }

    [JsonPropertyName("trialDays")]
    public required long TrialDays { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

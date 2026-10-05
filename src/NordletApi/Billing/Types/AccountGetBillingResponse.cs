using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountGetBillingResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("plan")]
    public required AccountGetBillingResponsePlan Plan { get; set; }

    [JsonPropertyName("status")]
    public required AccountGetBillingResponseStatus Status { get; set; }

    [JsonPropertyName("balanceCents")]
    public required long BalanceCents { get; set; }

    [JsonPropertyName("trialEndsAt")]
    public DateTime? TrialEndsAt { get; set; }

    [JsonPropertyName("firstTopUpAt")]
    public DateTime? FirstTopUpAt { get; set; }

    [JsonPropertyName("lastChargedDate")]
    public DateOnly? LastChargedDate { get; set; }

    [JsonPropertyName("paymentsConfigured")]
    public required bool PaymentsConfigured { get; set; }

    [JsonPropertyName("hasPaymentAccount")]
    public required bool HasPaymentAccount { get; set; }

    [JsonPropertyName("hasSubscription")]
    public required bool HasSubscription { get; set; }

    [JsonPropertyName("paymentFailedAt")]
    public DateTime? PaymentFailedAt { get; set; }

    [JsonPropertyName("paymentFailedInvoiceUrl")]
    public string? PaymentFailedInvoiceUrl { get; set; }

    [JsonPropertyName("monthToDate")]
    public required AccountGetBillingResponseMonthToDate MonthToDate { get; set; }

    [JsonPropertyName("plans")]
    public Dictionary<string, AccountGetBillingResponsePlansValue> Plans { get; set; } =
        new Dictionary<string, AccountGetBillingResponsePlansValue>();

    [JsonPropertyName("topUp")]
    public required AccountGetBillingResponseTopUp TopUp { get; set; }

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

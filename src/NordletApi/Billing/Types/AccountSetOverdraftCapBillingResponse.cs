using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountSetOverdraftCapBillingResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("plan")]
    public required AccountSetOverdraftCapBillingResponsePlan Plan { get; set; }

    [JsonPropertyName("accountType")]
    public required AccountSetOverdraftCapBillingResponseAccountType AccountType { get; set; }

    [JsonPropertyName("status")]
    public required AccountSetOverdraftCapBillingResponseStatus Status { get; set; }

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

    /// <summary>
    /// When the Stripe subscription ends after `subscription/cancel`; null while it renews
    /// </summary>
    [JsonPropertyName("subscriptionCancelAt")]
    public DateTime? SubscriptionCancelAt { get; set; }

    [JsonPropertyName("paymentFailedAt")]
    public DateTime? PaymentFailedAt { get; set; }

    [JsonPropertyName("paymentFailedInvoiceUrl")]
    public string? PaymentFailedInvoiceUrl { get; set; }

    [JsonPropertyName("monthToDate")]
    public required AccountSetOverdraftCapBillingResponseMonthToDate MonthToDate { get; set; }

    [JsonPropertyName("plans")]
    public Dictionary<string, AccountSetOverdraftCapBillingResponsePlansValue> Plans { get; set; } =
        new Dictionary<string, AccountSetOverdraftCapBillingResponsePlansValue>();

    [JsonPropertyName("apiRequestEur")]
    public required string ApiRequestEur { get; set; }

    [JsonPropertyName("topUp")]
    public required AccountSetOverdraftCapBillingResponseTopUp TopUp { get; set; }

    [JsonPropertyName("autoTopUp")]
    public required AccountSetOverdraftCapBillingResponseAutoTopUp AutoTopUp { get; set; }

    [JsonPropertyName("overdraftCapCents")]
    public required long OverdraftCapCents { get; set; }

    [JsonPropertyName("overdraftCapMaxCents")]
    public required long OverdraftCapMaxCents { get; set; }

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

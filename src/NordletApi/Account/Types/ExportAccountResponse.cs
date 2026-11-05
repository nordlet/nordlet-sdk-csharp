using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ExportAccountResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("generatedAt")]
    public required DateTime GeneratedAt { get; set; }

    [JsonPropertyName("user")]
    public required ExportAccountResponseUser User { get; set; }

    [JsonPropertyName("consent")]
    public required ExportAccountResponseConsent Consent { get; set; }

    [JsonPropertyName("memberships")]
    public IEnumerable<ExportAccountResponseMembershipsItem> Memberships { get; set; } =
        new List<ExportAccountResponseMembershipsItem>();

    [JsonPropertyName("sessions")]
    public IEnumerable<ExportAccountResponseSessionsItem> Sessions { get; set; } =
        new List<ExportAccountResponseSessionsItem>();

    [JsonPropertyName("billing")]
    public ExportAccountResponseBilling? Billing { get; set; }

    [JsonPropertyName("billingAccounts")]
    public IEnumerable<ExportAccountResponseBillingAccountsItem> BillingAccounts { get; set; } =
        new List<ExportAccountResponseBillingAccountsItem>();

    [JsonPropertyName("creditTransactions")]
    public IEnumerable<ExportAccountResponseCreditTransactionsItem> CreditTransactions { get; set; } =
        new List<ExportAccountResponseCreditTransactionsItem>();

    [JsonPropertyName("auditEntries")]
    public IEnumerable<ExportAccountResponseAuditEntriesItem> AuditEntries { get; set; } =
        new List<ExportAccountResponseAuditEntriesItem>();

    [JsonPropertyName("authEvents")]
    public IEnumerable<ExportAccountResponseAuthEventsItem> AuthEvents { get; set; } =
        new List<ExportAccountResponseAuthEventsItem>();

    [JsonPropertyName("apiKeys")]
    public IEnumerable<ExportAccountResponseApiKeysItem> ApiKeys { get; set; } =
        new List<ExportAccountResponseApiKeysItem>();

    [JsonPropertyName("oauthGrants")]
    public IEnumerable<ExportAccountResponseOauthGrantsItem> OauthGrants { get; set; } =
        new List<ExportAccountResponseOauthGrantsItem>();

    [JsonPropertyName("referralPoints")]
    public IEnumerable<ExportAccountResponseReferralPointsItem> ReferralPoints { get; set; } =
        new List<ExportAccountResponseReferralPointsItem>();

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

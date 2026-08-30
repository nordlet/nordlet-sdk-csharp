using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountExportResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("generatedAt")]
    public required string GeneratedAt { get; set; }

    [JsonPropertyName("user")]
    public required PostV1AccountExportResponseUser User { get; set; }

    [JsonPropertyName("consent")]
    public required PostV1AccountExportResponseConsent Consent { get; set; }

    [JsonPropertyName("memberships")]
    public IEnumerable<PostV1AccountExportResponseMembershipsItem> Memberships { get; set; } =
        new List<PostV1AccountExportResponseMembershipsItem>();

    [JsonPropertyName("sessions")]
    public IEnumerable<PostV1AccountExportResponseSessionsItem> Sessions { get; set; } =
        new List<PostV1AccountExportResponseSessionsItem>();

    [JsonPropertyName("billing")]
    public PostV1AccountExportResponseBilling? Billing { get; set; }

    [JsonPropertyName("creditTransactions")]
    public IEnumerable<PostV1AccountExportResponseCreditTransactionsItem> CreditTransactions { get; set; } =
        new List<PostV1AccountExportResponseCreditTransactionsItem>();

    [JsonPropertyName("auditEntries")]
    public IEnumerable<PostV1AccountExportResponseAuditEntriesItem> AuditEntries { get; set; } =
        new List<PostV1AccountExportResponseAuditEntriesItem>();

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

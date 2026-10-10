using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettlementsCommissionBankResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("externalId")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("category")]
    public required string Category { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("gross")]
    public required string Gross { get; set; }

    [JsonPropertyName("fee")]
    public required string Fee { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("sourceId")]
    public string? SourceId { get; set; }

    [JsonPropertyName("chargeId")]
    public string? ChargeId { get; set; }

    [JsonPropertyName("commissionPercent")]
    public string? CommissionPercent { get; set; }

    [JsonPropertyName("commissionAmount")]
    public string? CommissionAmount { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("matchedInvoiceId")]
    public string? MatchedInvoiceId { get; set; }

    [JsonPropertyName("matchStatus")]
    public required SettlementsCommissionBankResponseMatchStatus MatchStatus { get; set; }

    [JsonPropertyName("clearingBankAccountId")]
    public string? ClearingBankAccountId { get; set; }

    [JsonPropertyName("clearingBooked")]
    public string? ClearingBooked { get; set; }

    [JsonPropertyName("clearingDifference")]
    public string? ClearingDifference { get; set; }

    [JsonPropertyName("clearingUnposted")]
    public required bool ClearingUnposted { get; set; }

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

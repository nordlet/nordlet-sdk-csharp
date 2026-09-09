using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesUnlockResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required string CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required string IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required PostV1SalesInvoicesUnlockResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required PostV1SalesInvoicesUnlockResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public PostV1SalesInvoicesUnlockResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required PostV1SalesInvoicesUnlockResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public PostV1SalesInvoicesUnlockResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<PostV1SalesInvoicesUnlockResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<PostV1SalesInvoicesUnlockResponseVatEvidenceRatesItem>();

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

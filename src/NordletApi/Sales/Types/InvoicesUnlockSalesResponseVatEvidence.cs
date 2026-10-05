using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesUnlockSalesResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required DateTime CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required InvoicesUnlockSalesResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required InvoicesUnlockSalesResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public InvoicesUnlockSalesResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required InvoicesUnlockSalesResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public InvoicesUnlockSalesResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<InvoicesUnlockSalesResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<InvoicesUnlockSalesResponseVatEvidenceRatesItem>();

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

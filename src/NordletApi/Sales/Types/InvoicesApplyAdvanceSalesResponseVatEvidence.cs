using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesApplyAdvanceSalesResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required DateTime CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required InvoicesApplyAdvanceSalesResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required InvoicesApplyAdvanceSalesResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public InvoicesApplyAdvanceSalesResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required InvoicesApplyAdvanceSalesResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public InvoicesApplyAdvanceSalesResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<InvoicesApplyAdvanceSalesResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<InvoicesApplyAdvanceSalesResponseVatEvidenceRatesItem>();

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

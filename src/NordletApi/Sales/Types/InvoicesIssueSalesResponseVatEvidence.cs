using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesIssueSalesResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required DateTime CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required InvoicesIssueSalesResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required InvoicesIssueSalesResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public InvoicesIssueSalesResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required InvoicesIssueSalesResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public InvoicesIssueSalesResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<InvoicesIssueSalesResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<InvoicesIssueSalesResponseVatEvidenceRatesItem>();

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

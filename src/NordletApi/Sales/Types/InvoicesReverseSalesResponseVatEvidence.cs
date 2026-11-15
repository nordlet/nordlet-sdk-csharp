using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesReverseSalesResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required DateTime CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required InvoicesReverseSalesResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required InvoicesReverseSalesResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public InvoicesReverseSalesResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required InvoicesReverseSalesResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public InvoicesReverseSalesResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<InvoicesReverseSalesResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<InvoicesReverseSalesResponseVatEvidenceRatesItem>();

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

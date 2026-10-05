using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesCreateSalesResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required DateTime CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required InvoicesCreateSalesResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required InvoicesCreateSalesResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public InvoicesCreateSalesResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required InvoicesCreateSalesResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public InvoicesCreateSalesResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<InvoicesCreateSalesResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<InvoicesCreateSalesResponseVatEvidenceRatesItem>();

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesCreateResponseVatEvidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capturedAt")]
    public required string CapturedAt { get; set; }

    [JsonPropertyName("issueDate")]
    public required string IssueDate { get; set; }

    [JsonPropertyName("scheme")]
    public required PostV1SalesInvoicesCreateResponseVatEvidenceScheme Scheme { get; set; }

    [JsonPropertyName("partner")]
    public required PostV1SalesInvoicesCreateResponseVatEvidencePartner Partner { get; set; }

    [JsonPropertyName("vies")]
    public PostV1SalesInvoicesCreateResponseVatEvidenceVies? Vies { get; set; }

    [JsonPropertyName("location")]
    public required PostV1SalesInvoicesCreateResponseVatEvidenceLocation Location { get; set; }

    [JsonPropertyName("rateTable")]
    public PostV1SalesInvoicesCreateResponseVatEvidenceRateTable? RateTable { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<PostV1SalesInvoicesCreateResponseVatEvidenceRatesItem> Rates { get; set; } =
        new List<PostV1SalesInvoicesCreateResponseVatEvidenceRatesItem>();

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

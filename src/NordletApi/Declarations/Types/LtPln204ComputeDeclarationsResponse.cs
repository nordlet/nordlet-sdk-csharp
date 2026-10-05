using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtPln204ComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("variant")]
    public required LtPln204ComputeDeclarationsResponseVariant Variant { get; set; }

    [JsonPropertyName("registrationNumber")]
    public required string RegistrationNumber { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("ratePercent")]
    public required string RatePercent { get; set; }

    [JsonPropertyName("rateCode")]
    public required string RateCode { get; set; }

    [JsonPropertyName("smallEntity")]
    public required bool SmallEntity { get; set; }

    [JsonPropertyName("criteria")]
    public required LtPln204ComputeDeclarationsResponseCriteria Criteria { get; set; }

    [JsonPropertyName("totalIncome")]
    public required string TotalIncome { get; set; }

    [JsonPropertyName("boxes")]
    public Dictionary<string, string> Boxes { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("annexS")]
    public IEnumerable<LtPln204ComputeDeclarationsResponseAnnexSItem> AnnexS { get; set; } =
        new List<LtPln204ComputeDeclarationsResponseAnnexSItem>();

    [JsonPropertyName("annexZ")]
    public IEnumerable<LtPln204ComputeDeclarationsResponseAnnexZItem> AnnexZ { get; set; } =
        new List<LtPln204ComputeDeclarationsResponseAnnexZItem>();

    [JsonPropertyName("lines")]
    public IEnumerable<LtPln204ComputeDeclarationsResponseLinesItem> Lines { get; set; } =
        new List<LtPln204ComputeDeclarationsResponseLinesItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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

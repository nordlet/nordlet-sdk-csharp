using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtPln204ComputeResponse : IJsonOnDeserialized
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
    public required PostV1DeclarationsLtPln204ComputeResponseVariant Variant { get; set; }

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
    public required PostV1DeclarationsLtPln204ComputeResponseCriteria Criteria { get; set; }

    [JsonPropertyName("totalIncome")]
    public required string TotalIncome { get; set; }

    [JsonPropertyName("boxes")]
    public Dictionary<string, string> Boxes { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("annexS")]
    public IEnumerable<PostV1DeclarationsLtPln204ComputeResponseAnnexSItem> AnnexS { get; set; } =
        new List<PostV1DeclarationsLtPln204ComputeResponseAnnexSItem>();

    [JsonPropertyName("annexZ")]
    public IEnumerable<PostV1DeclarationsLtPln204ComputeResponseAnnexZItem> AnnexZ { get; set; } =
        new List<PostV1DeclarationsLtPln204ComputeResponseAnnexZItem>();

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1DeclarationsLtPln204ComputeResponseLinesItem> Lines { get; set; } =
        new List<PostV1DeclarationsLtPln204ComputeResponseLinesItem>();

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

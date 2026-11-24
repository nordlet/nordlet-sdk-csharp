using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuOssNonUnionComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodYear")]
    public required long PeriodYear { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("memberStateOfIdentification")]
    public required string MemberStateOfIdentification { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<EuOssNonUnionComputeDeclarationsResponseRowsItem> Rows { get; set; } =
        new List<EuOssNonUnionComputeDeclarationsResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required EuOssNonUnionComputeDeclarationsResponseTotals Totals { get; set; }

    [JsonPropertyName("corrections")]
    public IEnumerable<EuOssNonUnionComputeDeclarationsResponseCorrectionsItem> Corrections { get; set; } =
        new List<EuOssNonUnionComputeDeclarationsResponseCorrectionsItem>();

    [JsonPropertyName("correctionsTotal")]
    public required EuOssNonUnionComputeDeclarationsResponseCorrectionsTotal CorrectionsTotal { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("periodQuarter")]
    public required long PeriodQuarter { get; set; }

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

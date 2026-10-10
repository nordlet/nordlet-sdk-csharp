using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuOwnGoodsTransfersComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodYear")]
    public required long PeriodYear { get; set; }

    [JsonPropertyName("periodMonth")]
    public required long PeriodMonth { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("dueDate")]
    public required DateOnly DueDate { get; set; }

    [JsonPropertyName("memberStateOfIdentification")]
    public required string MemberStateOfIdentification { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<EuOwnGoodsTransfersComputeDeclarationsResponseRowsItem> Rows { get; set; } =
        new List<EuOwnGoodsTransfersComputeDeclarationsResponseRowsItem>();

    [JsonPropertyName("total")]
    public required string Total { get; set; }

    [JsonPropertyName("transfers")]
    public IEnumerable<EuOwnGoodsTransfersComputeDeclarationsResponseTransfersItem> Transfers { get; set; } =
        new List<EuOwnGoodsTransfersComputeDeclarationsResponseTransfersItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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

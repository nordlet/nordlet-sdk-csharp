using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuIossComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodYear")]
    public required long PeriodYear { get; set; }

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("memberStateOfIdentification")]
    public required string MemberStateOfIdentification { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1DeclarationsEuIossComputeResponseRowsItem> Rows { get; set; } =
        new List<PostV1DeclarationsEuIossComputeResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required PostV1DeclarationsEuIossComputeResponseTotals Totals { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("periodMonth")]
    public required long PeriodMonth { get; set; }

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

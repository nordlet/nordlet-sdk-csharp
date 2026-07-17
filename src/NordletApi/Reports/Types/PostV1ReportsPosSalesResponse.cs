using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsPosSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsPosSalesResponseRowsItem> Rows { get; set; } =
        new List<PostV1ReportsPosSalesResponseRowsItem>();

    [JsonPropertyName("byRate")]
    public IEnumerable<PostV1ReportsPosSalesResponseByRateItem> ByRate { get; set; } =
        new List<PostV1ReportsPosSalesResponseByRateItem>();

    [JsonPropertyName("totals")]
    public required PostV1ReportsPosSalesResponseTotals Totals { get; set; }

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

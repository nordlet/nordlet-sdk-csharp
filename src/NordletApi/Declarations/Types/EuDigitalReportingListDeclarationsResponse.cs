using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuDigitalReportingListDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("appliesFrom")]
    public required string AppliesFrom { get; set; }

    [JsonPropertyName("reportTo")]
    public required string ReportTo { get; set; }

    [JsonPropertyName("transactions")]
    public IEnumerable<EuDigitalReportingListDeclarationsResponseTransactionsItem> Transactions { get; set; } =
        new List<EuDigitalReportingListDeclarationsResponseTransactionsItem>();

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

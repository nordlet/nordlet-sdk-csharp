using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtGpm312ComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("payoutTiming")]
    public required LtGpm312ComputeDeclarationsResponsePayoutTiming PayoutTiming { get; set; }

    [JsonPropertyName("payoutFrom")]
    public required LtGpm312ComputeDeclarationsResponsePayoutFrom PayoutFrom { get; set; }

    [JsonPropertyName("payoutTo")]
    public required LtGpm312ComputeDeclarationsResponsePayoutTo PayoutTo { get; set; }

    [JsonPropertyName("registrationNumber")]
    public required string RegistrationNumber { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<LtGpm312ComputeDeclarationsResponseRowsItem> Rows { get; set; } =
        new List<LtGpm312ComputeDeclarationsResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required LtGpm312ComputeDeclarationsResponseTotals Totals { get; set; }

    [JsonPropertyName("runsFound")]
    public required long RunsFound { get; set; }

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

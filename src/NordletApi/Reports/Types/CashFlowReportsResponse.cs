using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CashFlowReportsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("openingCash")]
    public required string OpeningCash { get; set; }

    [JsonPropertyName("closingCash")]
    public required string ClosingCash { get; set; }

    [JsonPropertyName("netChange")]
    public required string NetChange { get; set; }

    [JsonPropertyName("operating")]
    public required CashFlowReportsResponseOperating Operating { get; set; }

    [JsonPropertyName("investing")]
    public required CashFlowReportsResponseInvesting Investing { get; set; }

    [JsonPropertyName("financing")]
    public required CashFlowReportsResponseFinancing Financing { get; set; }

    [JsonPropertyName("balanced")]
    public required bool Balanced { get; set; }

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

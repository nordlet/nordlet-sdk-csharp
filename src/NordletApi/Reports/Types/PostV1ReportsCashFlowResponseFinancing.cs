using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsCashFlowResponseFinancing : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("inflow")]
    public required string Inflow { get; set; }

    [JsonPropertyName("outflow")]
    public required string Outflow { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsCashFlowResponseFinancingRowsItem> Rows { get; set; } =
        new List<PostV1ReportsCashFlowResponseFinancingRowsItem>();

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

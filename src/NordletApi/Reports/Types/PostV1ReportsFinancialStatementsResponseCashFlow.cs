using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsFinancialStatementsResponseCashFlow : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("openingCash")]
    public required string OpeningCash { get; set; }

    [JsonPropertyName("operating")]
    public required string Operating { get; set; }

    [JsonPropertyName("investing")]
    public required string Investing { get; set; }

    [JsonPropertyName("financing")]
    public required string Financing { get; set; }

    [JsonPropertyName("netChange")]
    public required string NetChange { get; set; }

    [JsonPropertyName("closingCash")]
    public required string ClosingCash { get; set; }

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

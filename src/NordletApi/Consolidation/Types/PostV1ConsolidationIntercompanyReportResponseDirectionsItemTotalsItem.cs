using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationIntercompanyReportResponseDirectionsItemTotalsItem
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("salesGross")]
    public required string SalesGross { get; set; }

    [JsonPropertyName("purchasesGross")]
    public required string PurchasesGross { get; set; }

    [JsonPropertyName("grossDifference")]
    public required string GrossDifference { get; set; }

    [JsonPropertyName("openReceivable")]
    public required string OpenReceivable { get; set; }

    [JsonPropertyName("openPayable")]
    public required string OpenPayable { get; set; }

    [JsonPropertyName("openDifference")]
    public required string OpenDifference { get; set; }

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

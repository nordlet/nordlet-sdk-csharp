using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsStockBalanceResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsStockBalanceResponseRowsItem> Rows { get; set; } =
        new List<PostV1ReportsStockBalanceResponseRowsItem>();

    [JsonPropertyName("totalValue")]
    public required string TotalValue { get; set; }

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

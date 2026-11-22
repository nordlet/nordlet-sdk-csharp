using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP45GetDeclarationsResponseLastEntries : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("weekNumber")]
    public double? WeekNumber { get; set; }

    [JsonPropertyName("monthNumber")]
    public double? MonthNumber { get; set; }

    [JsonPropertyName("totalPayToDate")]
    public required DateOnly TotalPayToDate { get; set; }

    [JsonPropertyName("totalTaxToDate")]
    public required DateOnly TotalTaxToDate { get; set; }

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

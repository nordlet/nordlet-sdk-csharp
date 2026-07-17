using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsDebtAgingResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("side")]
    public required string Side { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsDebtAgingResponseRowsItem> Rows { get; set; } =
        new List<PostV1ReportsDebtAgingResponseRowsItem>();

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

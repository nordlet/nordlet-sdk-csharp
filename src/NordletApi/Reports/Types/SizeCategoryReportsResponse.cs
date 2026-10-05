using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SizeCategoryReportsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("criteria")]
    public required SizeCategoryReportsResponseCriteria Criteria { get; set; }

    [JsonPropertyName("category")]
    public required SizeCategoryReportsResponseCategory Category { get; set; }

    [JsonPropertyName("thresholds")]
    public Dictionary<string, SizeCategoryReportsResponseThresholdsValue> Thresholds { get; set; } =
        new Dictionary<string, SizeCategoryReportsResponseThresholdsValue>();

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

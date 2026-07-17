using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsSizeCategoryResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("criteria")]
    public required PostV1ReportsSizeCategoryResponseCriteria Criteria { get; set; }

    [JsonPropertyName("category")]
    public required PostV1ReportsSizeCategoryResponseCategory Category { get; set; }

    [JsonPropertyName("thresholds")]
    public Dictionary<
        string,
        PostV1ReportsSizeCategoryResponseThresholdsValue
    > Thresholds { get; set; } =
        new Dictionary<string, PostV1ReportsSizeCategoryResponseThresholdsValue>();

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

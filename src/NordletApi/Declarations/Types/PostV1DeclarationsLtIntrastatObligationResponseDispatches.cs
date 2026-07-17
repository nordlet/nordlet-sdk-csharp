using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatObligationResponseDispatches : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("previousYearValue")]
    public required string PreviousYearValue { get; set; }

    [JsonPropertyName("obligatedFromMonth")]
    public long? ObligatedFromMonth { get; set; }

    [JsonPropertyName("statisticalValueRequired")]
    public required bool StatisticalValueRequired { get; set; }

    [JsonPropertyName("monthly")]
    public IEnumerable<PostV1DeclarationsLtIntrastatObligationResponseDispatchesMonthlyItem> Monthly { get; set; } =
        new List<PostV1DeclarationsLtIntrastatObligationResponseDispatchesMonthlyItem>();

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

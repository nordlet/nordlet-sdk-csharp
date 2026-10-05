using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuSmeThresholdsListDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nationalCapEur")]
    public required string NationalCapEur { get; set; }

    [JsonPropertyName("unionTurnoverCapEur")]
    public required string UnionTurnoverCapEur { get; set; }

    [JsonPropertyName("thresholds")]
    public IEnumerable<EuSmeThresholdsListDeclarationsResponseThresholdsItem> Thresholds { get; set; } =
        new List<EuSmeThresholdsListDeclarationsResponseThresholdsItem>();

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

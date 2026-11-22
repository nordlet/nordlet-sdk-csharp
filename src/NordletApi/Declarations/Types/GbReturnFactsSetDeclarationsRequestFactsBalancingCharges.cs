using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbReturnFactsSetDeclarationsRequestFactsBalancingCharges : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fullExpensing")]
    public string? FullExpensing { get; set; }

    [JsonPropertyName("specialRatePool")]
    public string? SpecialRatePool { get; set; }

    [JsonPropertyName("mainPool")]
    public string? MainPool { get; set; }

    [JsonPropertyName("other")]
    public string? Other { get; set; }

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

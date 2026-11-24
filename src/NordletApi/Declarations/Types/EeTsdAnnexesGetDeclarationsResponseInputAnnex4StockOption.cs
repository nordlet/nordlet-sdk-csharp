using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOption : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// `sale`: the option was sold (4081 – 4083); `exercise`: the shares were acquired (4081 – 4082 – 4083)
    /// </summary>
    [JsonPropertyName("event")]
    public required EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent Event { get; set; }

    /// <summary>
    /// 4081: market price
    /// </summary>
    [JsonPropertyName("marketPrice")]
    public required string MarketPrice { get; set; }

    /// <summary>
    /// 4082: exercise price, for `exercise` only
    /// </summary>
    [JsonPropertyName("exercisePrice")]
    public string? ExercisePrice { get; set; }

    /// <summary>
    /// 4083: option premium
    /// </summary>
    [JsonPropertyName("premium")]
    public required string Premium { get; set; }

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

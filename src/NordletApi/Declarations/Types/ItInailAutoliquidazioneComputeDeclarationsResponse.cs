using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("positions")]
    public IEnumerable<ItInailAutoliquidazioneComputeDeclarationsResponsePositionsItem> Positions { get; set; } =
        new List<ItInailAutoliquidazioneComputeDeclarationsResponsePositionsItem>();

    [JsonPropertyName("regolazione")]
    public required ItInailAutoliquidazioneComputeDeclarationsResponseRegolazione Regolazione { get; set; }

    [JsonPropertyName("rata")]
    public required ItInailAutoliquidazioneComputeDeclarationsResponseRata Rata { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

    [JsonPropertyName("instalments")]
    public IEnumerable<ItInailAutoliquidazioneComputeDeclarationsResponseInstalmentsItem> Instalments { get; set; } =
        new List<ItInailAutoliquidazioneComputeDeclarationsResponseInstalmentsItem>();

    [JsonPropertyName("f24")]
    public IEnumerable<ItInailAutoliquidazioneComputeDeclarationsResponseF24Item> F24 { get; set; } =
        new List<ItInailAutoliquidazioneComputeDeclarationsResponseF24Item>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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

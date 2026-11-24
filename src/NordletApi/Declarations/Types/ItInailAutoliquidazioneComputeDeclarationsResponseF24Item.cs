using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneComputeDeclarationsResponseF24Item : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("codiceSede")]
    public required string CodiceSede { get; set; }

    [JsonPropertyName("codiceDitta")]
    public required string CodiceDitta { get; set; }

    [JsonPropertyName("cc")]
    public required string Cc { get; set; }

    [JsonPropertyName("numeroRiferimento")]
    public required string NumeroRiferimento { get; set; }

    [JsonPropertyName("causale")]
    public required string Causale { get; set; }

    [JsonPropertyName("importo")]
    public required string Importo { get; set; }

    [JsonPropertyName("credito")]
    public bool? Credito { get; set; }

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

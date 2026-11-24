using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneComputeDeclarationsResponsePositionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pat")]
    public required string Pat { get; set; }

    [JsonPropertyName("patControlCode")]
    public required string PatControlCode { get; set; }

    [JsonPropertyName("voce")]
    public required string Voce { get; set; }

    [JsonPropertyName("employees")]
    public required long Employees { get; set; }

    [JsonPropertyName("retribuzioni")]
    public required string Retribuzioni { get; set; }

    [JsonPropertyName("quoteEsenti")]
    public required string QuoteEsenti { get; set; }

    [JsonPropertyName("imponibileRegolazione")]
    public required string ImponibileRegolazione { get; set; }

    [JsonPropertyName("premioRegolazione")]
    public required string PremioRegolazione { get; set; }

    [JsonPropertyName("riduzioneRegolazione")]
    public required string RiduzioneRegolazione { get; set; }

    [JsonPropertyName("totaleRegolazione")]
    public required string TotaleRegolazione { get; set; }

    [JsonPropertyName("imponibileRata")]
    public required string ImponibileRata { get; set; }

    [JsonPropertyName("premioRata")]
    public required string PremioRata { get; set; }

    [JsonPropertyName("riduzioneRata")]
    public required string RiduzioneRata { get; set; }

    [JsonPropertyName("totaleRata")]
    public required string TotaleRata { get; set; }

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

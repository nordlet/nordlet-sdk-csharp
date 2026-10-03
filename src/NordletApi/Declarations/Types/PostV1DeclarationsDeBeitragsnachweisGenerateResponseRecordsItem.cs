using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsDeBeitragsnachweisGenerateResponseRecordsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("betriebsnummerKrankenkasse")]
    public required string BetriebsnummerKrankenkasse { get; set; }

    [JsonPropertyName("faelligkeitstag")]
    public required string Faelligkeitstag { get; set; }

    [JsonPropertyName("kvAllgemein")]
    public required string KvAllgemein { get; set; }

    [JsonPropertyName("kvZusatzbeitrag")]
    public required string KvZusatzbeitrag { get; set; }

    [JsonPropertyName("pauschsteuer")]
    public required string Pauschsteuer { get; set; }

    [JsonPropertyName("beitragssatzAllgemein")]
    public required string BeitragssatzAllgemein { get; set; }

    [JsonPropertyName("summe")]
    public required string Summe { get; set; }

    [JsonPropertyName("positionen")]
    public IEnumerable<PostV1DeclarationsDeBeitragsnachweisGenerateResponseRecordsItemPositionenItem> Positionen { get; set; } =
        new List<PostV1DeclarationsDeBeitragsnachweisGenerateResponseRecordsItemPositionenItem>();

    [JsonPropertyName("record")]
    public required string Record { get; set; }

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

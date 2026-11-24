using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem : IJsonOnDeserialized
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

    [JsonPropertyName("tassoRegolazione")]
    public required string TassoRegolazione { get; set; }

    [JsonPropertyName("tassoRata")]
    public required string TassoRata { get; set; }

    [JsonPropertyName("riduzioneRegolazione")]
    public string? RiduzioneRegolazione { get; set; }

    [JsonPropertyName("riduzioneRata")]
    public string? RiduzioneRata { get; set; }

    [JsonPropertyName("quoteEsenti")]
    public string? QuoteEsenti { get; set; }

    [JsonPropertyName("retribuzioniRata")]
    public string? RetribuzioniRata { get; set; }

    [JsonPropertyName("employeeIds")]
    public IEnumerable<string>? EmployeeIds { get; set; }

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

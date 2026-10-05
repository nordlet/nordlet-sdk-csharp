using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DeDeuevGenerateDeclarationsResponseRecordsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("abgabegrund")]
    public required string Abgabegrund { get; set; }

    [JsonPropertyName("versicherungsnummer")]
    public required string Versicherungsnummer { get; set; }

    [JsonPropertyName("betriebsnummerKrankenkasse")]
    public required string BetriebsnummerKrankenkasse { get; set; }

    [JsonPropertyName("personengruppe")]
    public required string Personengruppe { get; set; }

    [JsonPropertyName("beitragsgruppe")]
    public required string Beitragsgruppe { get; set; }

    [JsonPropertyName("zeitraumBeginn")]
    public required string ZeitraumBeginn { get; set; }

    [JsonPropertyName("zeitraumEnde")]
    public string? ZeitraumEnde { get; set; }

    [JsonPropertyName("entgelt")]
    public required string Entgelt { get; set; }

    [JsonPropertyName("record")]
    public required string Record { get; set; }

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LiLohndeklarationGenerateDeclarationsResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("versichertennummer")]
    public required string Versichertennummer { get; set; }

    [JsonPropertyName("vorname")]
    public required string Vorname { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("geschlecht")]
    public required string Geschlecht { get; set; }

    [JsonPropertyName("heimatstaat")]
    public required string Heimatstaat { get; set; }

    [JsonPropertyName("eintrittsdatum")]
    public required string Eintrittsdatum { get; set; }

    [JsonPropertyName("austrittsdatum")]
    public required string Austrittsdatum { get; set; }

    [JsonPropertyName("beschaeftigtVon")]
    public required string BeschaeftigtVon { get; set; }

    [JsonPropertyName("beschaeftigtBis")]
    public required string BeschaeftigtBis { get; set; }

    [JsonPropertyName("beschaeftigungsgrad")]
    public required string Beschaeftigungsgrad { get; set; }

    [JsonPropertyName("ahvLohn")]
    public required string AhvLohn { get; set; }

    [JsonPropertyName("alv")]
    public required string Alv { get; set; }

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

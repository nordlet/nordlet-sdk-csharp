using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLiLohnlistenGenerateResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("peid")]
    public required string Peid { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("vorname")]
    public required string Vorname { get; set; }

    [JsonPropertyName("geburtsdatum")]
    public required string Geburtsdatum { get; set; }

    [JsonPropertyName("strasse")]
    public required string Strasse { get; set; }

    [JsonPropertyName("hausnummer")]
    public required string Hausnummer { get; set; }

    [JsonPropertyName("plz")]
    public required string Plz { get; set; }

    [JsonPropertyName("ort")]
    public required string Ort { get; set; }

    [JsonPropertyName("wohnland")]
    public required string Wohnland { get; set; }

    [JsonPropertyName("brutto")]
    public required string Brutto { get; set; }

    [JsonPropertyName("lohnsteuer")]
    public required string Lohnsteuer { get; set; }

    [JsonPropertyName("abrechnungVon")]
    public required string AbrechnungVon { get; set; }

    [JsonPropertyName("abrechnungBis")]
    public required string AbrechnungBis { get; set; }

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

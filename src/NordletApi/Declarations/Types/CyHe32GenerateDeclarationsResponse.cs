using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CyHe32GenerateDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("madeUpTo")]
    public required string MadeUpTo { get; set; }

    [JsonPropertyName("registrarNumber")]
    public required string RegistrarNumber { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("xml")]
    public required string Xml { get; set; }

    [JsonPropertyName("pdfFileName")]
    public required string PdfFileName { get; set; }

    [JsonPropertyName("pdf")]
    public required string Pdf { get; set; }

    [JsonPropertyName("formSource")]
    public required string FormSource { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<CyHe32GenerateDeclarationsResponseFieldsItem> Fields { get; set; } =
        new List<CyHe32GenerateDeclarationsResponseFieldsItem>();

    [JsonPropertyName("members")]
    public IEnumerable<CyHe32GenerateDeclarationsResponseMembersItem> Members { get; set; } =
        new List<CyHe32GenerateDeclarationsResponseMembersItem>();

    [JsonPropertyName("officers")]
    public IEnumerable<CyHe32GenerateDeclarationsResponseOfficersItem> Officers { get; set; } =
        new List<CyHe32GenerateDeclarationsResponseOfficersItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsMtAnnualReturnGenerateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("madeUpTo")]
    public string? MadeUpTo { get; set; }

    [JsonPropertyName("mbrNumber")]
    public required string MbrNumber { get; set; }

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
    public IEnumerable<PostV1DeclarationsMtAnnualReturnGenerateResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsMtAnnualReturnGenerateResponseFieldsItem>();

    [JsonPropertyName("members")]
    public IEnumerable<PostV1DeclarationsMtAnnualReturnGenerateResponseMembersItem> Members { get; set; } =
        new List<PostV1DeclarationsMtAnnualReturnGenerateResponseMembersItem>();

    [JsonPropertyName("officers")]
    public IEnumerable<PostV1DeclarationsMtAnnualReturnGenerateResponseOfficersItem> Officers { get; set; } =
        new List<PostV1DeclarationsMtAnnualReturnGenerateResponseOfficersItem>();

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

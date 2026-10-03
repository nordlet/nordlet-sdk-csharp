using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsMtCompanyTaxGenerateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("yearOfAssessment")]
    public required long YearOfAssessment { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("incomeTaxNumber")]
    public required string IncomeTaxNumber { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("xml")]
    public required string Xml { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1DeclarationsMtCompanyTaxGenerateResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsMtCompanyTaxGenerateResponseFieldsItem>();

    [JsonPropertyName("taxAccounts")]
    public IEnumerable<PostV1DeclarationsMtCompanyTaxGenerateResponseTaxAccountsItem> TaxAccounts { get; set; } =
        new List<PostV1DeclarationsMtCompanyTaxGenerateResponseTaxAccountsItem>();

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

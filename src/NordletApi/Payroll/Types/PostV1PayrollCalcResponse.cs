using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollCalcResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("taxAllowance")]
    public required string TaxAllowance { get; set; }

    [JsonPropertyName("incomeTax")]
    public required string IncomeTax { get; set; }

    [JsonPropertyName("employeeContributions")]
    public required string EmployeeContributions { get; set; }

    [JsonPropertyName("employerContributions")]
    public required string EmployerContributions { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1PayrollCalcResponseComponentsItem> Components { get; set; } =
        new List<PostV1PayrollCalcResponseComponentsItem>();

    [JsonPropertyName("net")]
    public required string Net { get; set; }

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

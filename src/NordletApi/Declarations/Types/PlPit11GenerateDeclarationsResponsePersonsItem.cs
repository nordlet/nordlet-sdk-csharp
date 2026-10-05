using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlPit11GenerateDeclarationsResponsePersonsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("pesel")]
    public string? Pesel { get; set; }

    [JsonPropertyName("revenue")]
    public required string Revenue { get; set; }

    [JsonPropertyName("deductibleCosts")]
    public required string DeductibleCosts { get; set; }

    [JsonPropertyName("advanceWithheld")]
    public required string AdvanceWithheld { get; set; }

    [JsonPropertyName("socialContributions")]
    public required string SocialContributions { get; set; }

    [JsonPropertyName("healthContributions")]
    public required string HealthContributions { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("xml")]
    public required string Xml { get; set; }

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

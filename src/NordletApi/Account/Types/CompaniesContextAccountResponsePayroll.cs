using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesContextAccountResponsePayroll : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("engine")]
    public required bool Engine { get; set; }

    [JsonPropertyName("employeeFields")]
    public IEnumerable<CompaniesContextAccountResponsePayrollEmployeeFieldsItem> EmployeeFields { get; set; } =
        new List<CompaniesContextAccountResponsePayrollEmployeeFieldsItem>();

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

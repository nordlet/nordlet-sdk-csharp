using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RunsCreatePayrollRequestLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("gross")]
    public string? Gross { get; set; }

    [JsonPropertyName("additions")]
    public IEnumerable<RunsCreatePayrollRequestLinesItemAdditionsItem>? Additions { get; set; }

    [JsonPropertyName("deductions")]
    public IEnumerable<RunsCreatePayrollRequestLinesItemDeductionsItem>? Deductions { get; set; }

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

using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollRunsCreateResponseLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("contractId")]
    public string? ContractId { get; set; }

    [JsonPropertyName("employeeName")]
    public required string EmployeeName { get; set; }

    [JsonPropertyName("gross")]
    public required string Gross { get; set; }

    [JsonPropertyName("natura")]
    public required string Natura { get; set; }

    [JsonPropertyName("additions")]
    public IEnumerable<PostV1PayrollRunsCreateResponseLinesItemAdditionsItem> Additions { get; set; } =
        new List<PostV1PayrollRunsCreateResponseLinesItemAdditionsItem>();

    [JsonPropertyName("deductions")]
    public IEnumerable<PostV1PayrollRunsCreateResponseLinesItemDeductionsItem> Deductions { get; set; } =
        new List<PostV1PayrollRunsCreateResponseLinesItemDeductionsItem>();

    [JsonPropertyName("taxableBase")]
    public required string TaxableBase { get; set; }

    [JsonPropertyName("npd")]
    public required string Npd { get; set; }

    [JsonPropertyName("gpm")]
    public required string Gpm { get; set; }

    [JsonPropertyName("sodraEmployee")]
    public required string SodraEmployee { get; set; }

    [JsonPropertyName("sodraEmployer")]
    public required string SodraEmployer { get; set; }

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

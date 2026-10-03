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

    [JsonPropertyName("taxAllowance")]
    public required string TaxAllowance { get; set; }

    [JsonPropertyName("incomeTax")]
    public required string IncomeTax { get; set; }

    [JsonPropertyName("employeeContributions")]
    public required string EmployeeContributions { get; set; }

    [JsonPropertyName("employerContributions")]
    public required string EmployerContributions { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1PayrollRunsCreateResponseLinesItemComponentsItem> Components { get; set; } =
        new List<PostV1PayrollRunsCreateResponseLinesItemComponentsItem>();

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("daysWorked")]
    public string? DaysWorked { get; set; }

    [JsonPropertyName("hoursWorked")]
    public string? HoursWorked { get; set; }

    [JsonPropertyName("registeredDays")]
    public string? RegisteredDays { get; set; }

    [JsonPropertyName("averageHourlyEarnings")]
    public string? AverageHourlyEarnings { get; set; }

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

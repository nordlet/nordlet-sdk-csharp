using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrContractsEndResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("positionId")]
    public string? PositionId { get; set; }

    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    [JsonPropertyName("scheduleId")]
    public string? ScheduleId { get; set; }

    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; set; }

    [JsonPropertyName("contractNo")]
    public required string ContractNo { get; set; }

    [JsonPropertyName("type")]
    public required PostV1HrContractsEndResponseType Type { get; set; }

    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    [JsonPropertyName("endReason")]
    public string? EndReason { get; set; }

    [JsonPropertyName("baseSalary")]
    public required string BaseSalary { get; set; }

    [JsonPropertyName("salaryType")]
    public required PostV1HrContractsEndResponseSalaryType SalaryType { get; set; }

    [JsonPropertyName("workHours")]
    public required string WorkHours { get; set; }

    [JsonPropertyName("workHoursUnit")]
    public required PostV1HrContractsEndResponseWorkHoursUnit WorkHoursUnit { get; set; }

    [JsonPropertyName("status")]
    public required PostV1HrContractsEndResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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

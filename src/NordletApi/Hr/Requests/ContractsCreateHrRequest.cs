using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ContractsCreateHrRequest
{
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
    public string? ContractNo { get; set; }

    [JsonPropertyName("type")]
    public ContractsCreateHrRequestType? Type { get; set; }

    [JsonPropertyName("startDate")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("baseSalary")]
    public required string BaseSalary { get; set; }

    [JsonPropertyName("salaryType")]
    public ContractsCreateHrRequestSalaryType? SalaryType { get; set; }

    [JsonPropertyName("workHours")]
    public string? WorkHours { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrContractsCreateRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("positionId")]
    public string? PositionId { get; set; }

    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    [JsonPropertyName("scheduleId")]
    public string? ScheduleId { get; set; }

    [JsonPropertyName("contractNo")]
    public required string ContractNo { get; set; }

    [JsonPropertyName("type")]
    public PostV1HrContractsCreateRequestType? Type { get; set; }

    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    [JsonPropertyName("baseSalary")]
    public required string BaseSalary { get; set; }

    [JsonPropertyName("salaryType")]
    public PostV1HrContractsCreateRequestSalaryType? SalaryType { get; set; }

    [JsonPropertyName("workHoursPerWeek")]
    public string? WorkHoursPerWeek { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

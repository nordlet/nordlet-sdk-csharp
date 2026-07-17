using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrLeaveBalancesListRequest
{
    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    [JsonPropertyName("year")]
    public long? Year { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

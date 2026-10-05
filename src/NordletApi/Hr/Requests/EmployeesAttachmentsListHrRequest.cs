using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EmployeesAttachmentsListHrRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

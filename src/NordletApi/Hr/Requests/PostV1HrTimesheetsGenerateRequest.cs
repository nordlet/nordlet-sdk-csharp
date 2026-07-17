using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrTimesheetsGenerateRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

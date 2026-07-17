using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrTimesheetsUpsertRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("days")]
    public IEnumerable<PostV1HrTimesheetsUpsertRequestDaysItem> Days { get; set; } =
        new List<PostV1HrTimesheetsUpsertRequestDaysItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

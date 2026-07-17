using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrEmployeesRecordsCreateRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1HrEmployeesRecordsCreateRequestType Type { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("institution")]
    public string? Institution { get; set; }

    [JsonPropertyName("issuedAt")]
    public string? IssuedAt { get; set; }

    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

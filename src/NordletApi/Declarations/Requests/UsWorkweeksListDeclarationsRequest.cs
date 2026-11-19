using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsWorkweeksListDeclarationsRequest
{
    [JsonPropertyName("from")]
    public required DateOnly From { get; set; }

    [JsonPropertyName("to")]
    public required DateOnly To { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

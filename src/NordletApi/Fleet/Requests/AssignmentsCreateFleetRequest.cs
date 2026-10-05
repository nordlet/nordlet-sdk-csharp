using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AssignmentsCreateFleetRequest
{
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public DateOnly? ToDate { get; set; }

    [JsonPropertyName("privateUse")]
    public bool? PrivateUse { get; set; }

    [JsonPropertyName("employerPaysFuel")]
    public bool? EmployerPaysFuel { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BusinessTripsCreateHrRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("destinationCountryCode")]
    public required string DestinationCountryCode { get; set; }

    [JsonPropertyName("purpose")]
    public required string Purpose { get; set; }

    [JsonPropertyName("startDate")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public required DateOnly EndDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

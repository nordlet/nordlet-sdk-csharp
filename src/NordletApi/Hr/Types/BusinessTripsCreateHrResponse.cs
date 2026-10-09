using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BusinessTripsCreateHrResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

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

    [JsonPropertyName("days")]
    public required long Days { get; set; }

    [JsonPropertyName("dailyRate")]
    public required string DailyRate { get; set; }

    [JsonPropertyName("perDiemAmount")]
    public required string PerDiemAmount { get; set; }

    [JsonPropertyName("status")]
    public required BusinessTripsCreateHrResponseStatus Status { get; set; }

    [JsonPropertyName("payrollRunId")]
    public string? PayrollRunId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

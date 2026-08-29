using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1FleetNaturaPreviewResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("employeeName")]
    public required string EmployeeName { get; set; }

    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    [JsonPropertyName("plateNumber")]
    public required string PlateNumber { get; set; }

    [JsonPropertyName("make")]
    public required string Make { get; set; }

    [JsonPropertyName("model")]
    public required string Model { get; set; }

    [JsonPropertyName("marketValue")]
    public required string MarketValue { get; set; }

    [JsonPropertyName("employerPaysFuel")]
    public required bool EmployerPaysFuel { get; set; }

    [JsonPropertyName("ratePercent")]
    public required string RatePercent { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

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

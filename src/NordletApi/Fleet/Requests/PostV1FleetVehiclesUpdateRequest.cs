using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1FleetVehiclesUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("plateNumber")]
    public string? PlateNumber { get; set; }

    [JsonPropertyName("make")]
    public string? Make { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("year")]
    public long? Year { get; set; }

    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("fuelType")]
    public PostV1FleetVehiclesUpdateRequestFuelType? FuelType { get; set; }

    [JsonPropertyName("acquisitionDate")]
    public string? AcquisitionDate { get; set; }

    [JsonPropertyName("marketValue")]
    public string? MarketValue { get; set; }

    [JsonPropertyName("fixedAssetId")]
    public string? FixedAssetId { get; set; }

    [JsonPropertyName("technicalInspectionDue")]
    public string? TechnicalInspectionDue { get; set; }

    [JsonPropertyName("insuranceDue")]
    public string? InsuranceDue { get; set; }

    [JsonPropertyName("status")]
    public PostV1FleetVehiclesUpdateRequestStatus? Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
